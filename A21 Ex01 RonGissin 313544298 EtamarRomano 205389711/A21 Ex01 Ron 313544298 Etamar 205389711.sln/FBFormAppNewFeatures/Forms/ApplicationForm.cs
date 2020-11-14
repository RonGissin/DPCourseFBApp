using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBFormAppNewFeatures.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public partial class ApplicationForm : Form
    {
        private User m_LoggedInUser;
        private User m_AlbumsUser;
        private AlbumPhotosForm m_AlbumPhotosForm;
        private BestFriendForm m_BestFriendForm;
        private UserMatcher m_UserMatcher;

        public ApplicationForm(User i_LoggedInUser)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_AlbumsUser = m_LoggedInUser;
            m_UserMatcher = new UserMatcher();
            
            InitializeComponent();
            InjectUserData();
            CenterToScreen();
        }

        public void InjectUserData()
        {
            fetchProfilePicture();
            fetchUserAlbums();
            fetchMostLikedPhoto();
            HiLoggedUserLabel.Text = $"Hi, {m_LoggedInUser.FirstName}";
            AlbumsLabel.Text = $"{m_AlbumsUser.Name}'s Albums";
        }

        private void fetchMostLikedPhoto()
        {
            Photo mostLikedPhoto = m_AlbumsUser.Albums
                .SelectMany(album => album.Photos)
                .OrderByDescending(photo => photo.LikedBy.Count())
                .FirstOrDefault();

            MostLikedPhotoPictureBox.LoadAsync(mostLikedPhoto.PictureNormalURL);
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

        private void AlbumsListView_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            showAlbumPhotosForm();
            Cursor = Cursors.Default;
        }

        private void ChangeAlbumOwnerButton_Click(object sender, EventArgs e)
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Dispose();
            Close();
        }

        
        private void BestFriendButton_Click(object sender, EventArgs e)
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
                .FirstOrDefault()?
                .User;
            } 
            catch
            {
                bestFriend = m_LoggedInUser;
            }
            

            m_BestFriendForm = new BestFriendForm(bestFriend);
            m_BestFriendForm.ShowDialog();
        }

        private void FindLoveButton_Click(object sender, EventArgs e)
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
    }
}
