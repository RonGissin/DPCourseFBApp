using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppCore.AppSettings;
using FBAppCore.Login;
using FBAppInfra.Validation;

namespace FBAppUI.Forms
{
    public partial class ApplicationForm : Form, IDataInjectable
    {
        private const string k_SettingsNotSavedMessage = "Your settings couldn't be saved for some reason.. you will have to reconnect next time !";
        private User m_LoggedInUser;
        private User m_AlbumsUser;
        private AlbumPhotosForm m_AlbumPhotosForm;
        private BestFriendForm m_BestFriendForm;
        private UserMatcher m_UserMatcher;
        private AppSettings m_AppSettings;
        private string m_LastAccessToken;
        private ISettingsFileHandler m_SettingsHandler;

        public ApplicationForm(LoginResultData i_LoginResultData, AppSettings i_AppSettings)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoginResultData, nameof(i_LoginResultData)).User;
            m_AppSettings = InputGuard.CheckNullArgument(i_AppSettings, nameof(i_AppSettings));
            m_SettingsHandler = AppXmlSettingsHandler.Instance;
            m_LastAccessToken = i_LoginResultData.AccessToken;
            m_AlbumsUser = m_LoggedInUser;
            m_UserMatcher = new UserMatcher();

            InitializeComponent();
            CenterToScreen();
            setFormViewBySettings();
        }

        public void InjectData()
        {
            fetchProfilePicture();
            fetchUserAlbums();
            fetchMostLikedPhoto();

            HiLoggedUserLabel.Text = $"Hi, {m_LoggedInUser.FirstName}";
            AlbumsLabel.Text = $"{m_AlbumsUser.Name}'s Albums";
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
            User potentialFriend = m_LoggedInUser.Friends.Where(friend => friend.Name.Contains(potentialFriendName)).FirstOrDefault();

            if (potentialFriend != null)
            {
                m_AlbumsUser = potentialFriend;
                fetchUserAlbums();
                fetchMostLikedPhoto();
            }
            else
            {
                MessageBox.Show($"The current user {m_LoggedInUser.Name} has no friend named {potentialFriendName}");
            }
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            DialogResult = DialogResult.Abort;
            Dispose();
            Close();
        }
        
        private void bestFriendButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            User bestFriend;

            try
            {
                bestFriend = m_LoggedInUser.Albums
                .SelectMany(album => album.Photos)
                .SelectMany(photo => photo.Tags)
                .GroupBy(tag => tag.User.Name)
                .OrderByDescending(gp => gp.Count())
                .FirstOrDefault()
                .FirstOrDefault()
                ?.User;
            } 
            catch
            {
                bestFriend = m_LoggedInUser;
            }
            
            m_BestFriendForm = new BestFriendForm(bestFriend);
            m_BestFriendForm.ShowDialog();
        }

        private void findLoveButton_Click(object i_Sender, EventArgs i_EventArgs)
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
                bestMatch = m_UserMatcher.FindMatch(m_LoggedInUser, (user) => true);
            }
            else if (isMaleChecked && !isFemaleChecked)
            {
                bestMatch = m_UserMatcher.FindMatch(m_LoggedInUser, (user) => user.Gender == User.eGender.male);
            }
            else
            {
                bestMatch = m_UserMatcher.FindMatch(m_LoggedInUser, (user) => user.Gender == User.eGender.female);
            }

            BestMatchPictureBox.LoadAsync(bestMatch.PictureNormalURL);
            BestMatchPictureBox.Refresh();
        }

        private void fetchMostLikedPhoto()
        {
            Photo mostLikedPhoto = m_AlbumsUser.Albums
                .SelectMany(album => album.Photos)
                .OrderByDescending(photo => photo.LikedBy.Count())
                .FirstOrDefault();

            if (mostLikedPhoto != null)
            {
                MostLikedPhotoPictureBox.LoadAsync(mostLikedPhoto.PictureNormalURL);
            }

            MostLikedPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void fetchUserAlbums()
        {
            IEnumerable<Photo> albumCoverPhotos = m_AlbumsUser.Albums.Select(album => album.CoverPhoto);
            IEnumerable<string> albumNames = m_AlbumsUser.Albums.Select(album => album.Name);

            AlbumsListView.SetGrid(albumCoverPhotos, albumNames);
        }

        private void fetchProfilePicture()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ProfilePictureBox.Width - 3, ProfilePictureBox.Height - 3);
            Region region = new Region(gp);
            ProfilePictureBox.Region = region;
            ProfilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void showAlbumPhotosForm()
        {
            string albumToShowName = AlbumsListView.SelectedItems[0].SubItems[0].Text;
            Album albumToShow = m_AlbumsUser.Albums.Where(album => album.Name.Equals(albumToShowName)).FirstOrDefault();
            m_AlbumPhotosForm = new AlbumPhotosForm(albumToShow, m_LoggedInUser);
            m_AlbumPhotosForm.ShowDialog();
        }
    }
}
