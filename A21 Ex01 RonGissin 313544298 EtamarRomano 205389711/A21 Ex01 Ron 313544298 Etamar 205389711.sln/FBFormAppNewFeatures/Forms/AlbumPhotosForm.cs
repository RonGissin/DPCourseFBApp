using FacebookWrapper.ObjectModel;
using FBAppInfra.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FBFormAppNewFeatures.Forms
{
    public partial class AlbumPhotosForm : Form
    {
        private Album m_Album;
        private ImageForm m_ImageForm;
        private User m_LoggedInUser;

        public AlbumPhotosForm(Album i_Album, User i_LoggedInUser)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_Album = InputGuard.CheckNullArgument(i_Album, nameof(i_Album));
            Text = m_Album.Name;
            InitializeComponent();
            CenterToScreen();
        }

        public void InjectUserData()
        {
            SetAlbumToShow().WithAlbumLikes().WithAlbumLocation().WithAlbumDescription();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            InjectUserData();
        }

        private void AlbumPhotosListView_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            showPhotoForm();
            Cursor = Cursors.Default;
        }

        private AlbumPhotosForm WithAlbumDescription()
        {
            AlbumDescriptionData.Text = m_Album.Description;

            return this;
        }

        private AlbumPhotosForm WithAlbumLocation()
        {
            AlbumLocationData.Text = m_Album.Location;

            return this;
        }

        private AlbumPhotosForm WithAlbumTags()
        {
            IEnumerable<string> taggedUsers = m_Album.Photos
                .SelectMany(photo => photo.Tags?
                .Select(tag => tag.User.Name));

            if(taggedUsers.Count() > 0)
            {
                foreach (string taggedUser in taggedUsers)
                {
                    AlbumTagsListBox.Items.Add(taggedUser);
                }
            }

            return this;
        }

        private AlbumPhotosForm WithAlbumLikes()
        {
            int totalAlbumLikes = m_Album.Photos.Select(photo => photo.LikedBy.Count()).Sum();
            NumAlbumLikesLabel.Text = totalAlbumLikes.ToString();

            return this;
        }

        private AlbumPhotosForm SetAlbumToShow()
        {
            AlbumPhotosListView.SetGrid(m_Album.Photos);
            Text = m_Album.Name;
           
            return this;
        }

       
        private void showPhotoForm()
        {
            var item = AlbumPhotosListView.SelectedItems[0];
            Photo photoToShow = m_Album.Photos.ElementAt(item.ImageIndex);
            m_ImageForm = new ImageForm(photoToShow, m_LoggedInUser);
            m_ImageForm.ShowDialog();
            m_ImageForm.Dispose();
        }
    }
}
