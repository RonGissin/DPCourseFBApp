using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppCore.AppSettings;
using FBAppCore.Login;
using FBAppCore.ThreadingUtils;
using FBAppCore.Validation;

namespace FBAppUI.Forms
{
    public partial class ApplicationForm : Form, IDataInjectable
    {
        private const string k_SettingsNotSavedMessage = "Your settings couldn't be saved for some reason.. you will have to reconnect next time !";
        private AlbumPhotosForm m_AlbumPhotosForm;
        private BestFriendForm m_BestFriendForm;
        private AppSettings m_AppSettings;
        private string m_LastAccessToken;
        private ISettingsFileHandler m_SettingsHandler;
        private ThreadRunner m_ThreadRunner;
        private ApplicationLogicHandler m_LogicHandler;

        public ApplicationForm(LoginResultData i_LoginResultData, AppSettings i_AppSettings = null)
        {
            m_LogicHandler = ApplicationLogicHandler.Instance;
            m_LogicHandler.LoggedInUser = i_LoginResultData.User;
            m_LogicHandler.AlbumUser = i_LoginResultData.User;
            m_AppSettings = InputGuard.CheckNullArgument(i_AppSettings, nameof(i_AppSettings));
            m_SettingsHandler = AppXmlSettingsHandler.Instance;
            m_LastAccessToken = i_LoginResultData.AccessToken;
            m_ThreadRunner = new ThreadRunner();

            InitializeComponent();
            CenterToScreen();
            setFormViewBySettings();
        }

        public void InjectData()
        {
            List<Action> methodsToRun = new List<Action>
            {
                fetchUserAlbums,
                fetchMostLikedPhoto,
                fetchProfilePicture
            };

            m_ThreadRunner.RunMethodsAsSeperateThreads(methodsToRun);

            AlbumsLabel.Text = $"{m_LogicHandler.AlbumUser.Name}'s Albums";
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            base.OnShown(i_EventArgs);
            InjectData();
        }

        protected override void OnFormClosing(FormClosingEventArgs i_EventArgs)
        {
            base.OnFormClosing(i_EventArgs);

            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastAccessToken = m_LastAccessToken;
            m_AppSettings.RememberUser = this.RememberUserCheckBox.Checked;

            try
            {
                m_SettingsHandler.SaveSettingsToFile(m_AppSettings);
            }
            catch
            {
                MessageBox.Show(k_SettingsNotSavedMessage);
            }
        }

        private void setFormViewBySettings()
        {
            if (m_AppSettings != null)
            {
                this.Size = m_AppSettings.LastWindowSize;
                this.RememberUserCheckBox.Checked = m_AppSettings.RememberUser;
            }
        }

        private void albumsListView_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            Cursor = Cursors.WaitCursor;
            showAlbumPhotosForm();
            Cursor = Cursors.Default;
        }

        private void changeAlbumOwnerButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            string potentialFriendName = ShowAlbumsOfTextBox.Text;
            User potentialFriend = m_LogicHandler.LoggedInUser.Friends.Where(friend => friend.Name.Contains(potentialFriendName)).FirstOrDefault();

            if (potentialFriend != null)
            {
                m_LogicHandler.AlbumUser = potentialFriend;
                fetchUserAlbums();
            }
            else
            {
                MessageBox.Show($"The current user {m_LogicHandler.LoggedInUser.Name} has no friend named {potentialFriendName}");
            }
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            DialogResult = DialogResult.Abort;
            Dispose();
            Close();
        }

        private void fetchUserAlbums()
        {
            IEnumerable<Photo> albumCoverPhotos = null;
            IEnumerable<string> albumNames = null;

            try
            {
                albumCoverPhotos = m_LogicHandler.AlbumUser.Albums.Select(album => album.CoverPhoto);
                albumNames = m_LogicHandler.AlbumUser.Albums.Select(album => album.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("The server was throttled with requests.. some data will be missing.");
            }

            AlbumsListView.Invoke(new Action(() => AlbumsListView.SetGrid(albumCoverPhotos, albumNames)));
        }

        private void fetchProfilePicture()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ProfilePictureBox.Width - 3, ProfilePictureBox.Height - 3);
            Region region = new Region(gp);
            ProfilePictureBox.Invoke(new Action(() => ProfilePictureBox.Region = region));
            try
            {
                ProfilePictureBox.LoadAsync(m_LogicHandler.LoggedInUser.PictureNormalURL);
            }
            catch
            {
            }

            HiLoggedUserLabel.Invoke(new Action(() => HiLoggedUserLabel.Text = m_LogicHandler.LoggedInUser.Name));
        }

        private void showAlbumPhotosForm()
        {
            string albumToShowName = AlbumsListView.SelectedItems[0].SubItems[0].Text;
            Album albumToShow = m_LogicHandler.AlbumUser.Albums.Where(album => album.Name.Equals(albumToShowName)).FirstOrDefault();
            m_AlbumPhotosForm = new AlbumPhotosForm(albumToShow);
            m_AlbumPhotosForm.ShowDialog();
        }

        private void fetchMostLikedPhoto()
        {
            string mostLikedPhotoUrl = null;

            try
            {
                mostLikedPhotoUrl = m_LogicHandler.LoggedInUser.Albums
                .SelectMany(album => album.Photos)
                .OrderByDescending(photo => photo.LikedBy.Count())
                .FirstOrDefault()?
                .PictureNormalURL;

                MostLikedPhotoPictureBox.Invoke(new Action(() => MostLikedPhotoPictureBox.LoadAsync(mostLikedPhotoUrl)));
            }
            catch
            {
            }
        }

        private void bestFriendButton_Click(object sender, EventArgs e)
        {
            User bestFriend = m_LogicHandler.FindBestFriend(m_LogicHandler.LoggedInUser, (user) => true);

            m_BestFriendForm = new BestFriendForm(bestFriend);
            m_BestFriendForm.ShowDialog();
        }

        private void findLoveButton_Click(object sender, EventArgs e)
        {
            User bestMatch;
            bool isMaleChecked = MaleCheckBox.Checked;
            bool isFemaleChecked = FemaleCheckBox.Checked;

            if (!isFemaleChecked && !isMaleChecked)
            {
                MessageBox.Show("Please state what gender you prefer");
                return;
            }

            if (isFemaleChecked && isMaleChecked)
            {
                bestMatch = m_LogicHandler.FindTrueLove(m_LogicHandler.LoggedInUser, (user) => true);
            }
            else if (isMaleChecked && !isFemaleChecked)
            {
                bestMatch = m_LogicHandler.FindTrueLove(m_LogicHandler.LoggedInUser, (user) => user.Gender == User.eGender.male);
            }
            else
            {
                bestMatch = m_LogicHandler.FindTrueLove(m_LogicHandler.LoggedInUser, (user) => user.Gender == User.eGender.female);
            }

            BestMatchPictureBox.LoadAsync(bestMatch.PictureNormalURL);
            BestMatchPictureBox.Refresh();
        }
    }
}
