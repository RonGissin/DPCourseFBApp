using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBFormAppNewFeatures.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public ApplicationForm(User i_LoggedInUser)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_AlbumsUser = m_LoggedInUser;
            
            InitializeComponent();
            InjectFormDataByUser();
            CenterToScreen();
        }

        private void InjectFormDataByUser()
        {
            fetchProfilePicture();
            fetchUserAlbums();
            HiLoggedUserLabel.Text = $"Hi, {m_LoggedInUser.Name}";
            AlbumsLabel.Text = $"{m_LoggedInUser.Name}'s Albums";
        }

        private void fetchUserAlbums()
        {
            IEnumerable<Photo> albumCoverPhotos = m_AlbumsUser.Albums.Select(album => album.CoverPhoto);
            IEnumerable<string> albumNames = m_AlbumsUser.Albums.Select(album => album.Name);

            AlbumsListView.SetGrid(albumCoverPhotos, albumNames);
        }

        private void fetchProfilePicture()
        {
            ProfilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void showAlbumPhotosForm()
        {
            string albumToShowName = AlbumsListView.SelectedItems[0].SubItems[0].Text;
            Album albumToShow = m_AlbumsUser.Albums.Where(album => album.Name.Equals(albumToShowName)).FirstOrDefault();
            m_AlbumPhotosForm = new AlbumPhotosForm(albumToShow);
            m_AlbumPhotosForm.ShowDialog();
        }

        private void PostStatusLabel_Click(object sender, EventArgs e)
        {

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

        private void AlbumsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
