using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppInfra.Validation;

namespace FBAppUI.Forms
{
    public partial class AlbumPhotosForm : Form, IDataInjectable
    {
        private Album m_Album;
        private ImageForm m_ImageForm;
        private User m_LoggedInUser;

        public AlbumPhotosForm(Album i_Album, User i_LoggedInUser)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_Album = InputGuard.CheckNullArgument(i_Album, nameof(i_Album));
            this.Text = m_Album.Name;
            InitializeComponent();
            CenterToScreen();
        }

        public void InjectData()
        {
            setAlbumToShow().withAlbumLikes().withAlbumLocation().withAlbumDescription().withAlbumTags();
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            base.OnShown(i_EventArgs);

            InjectData();
        }

        private void albumPhotosListView_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            this.Cursor = Cursors.WaitCursor;
            showPhotoForm();
            this.Cursor = Cursors.Default;
        }

        private AlbumPhotosForm withAlbumDescription()
        {
            AlbumDescriptionData.Text = m_Album.Description;

            return this;
        }

        private AlbumPhotosForm withAlbumLocation()
        {
            AlbumLocationData.Text = m_Album.Location;

            return this;
        }

        private AlbumPhotosForm withAlbumTags()
        {
            IEnumerable<string> taggedUsers = null;

            try
            {
                taggedUsers = m_Album.Photos
                .SelectMany(photo => photo.Tags
                ?.Select(tag => tag.User.Name));

                if (taggedUsers != null && taggedUsers.Count() > 0)
                {
                    foreach (string taggedUser in taggedUsers)
                    {
                        AlbumTagsListBox.Items.Add(taggedUser);
                    }
                }
            }
            catch
            {
            }

            return this;
        }

        private AlbumPhotosForm withAlbumLikes()
        {
            int totalAlbumLikes = m_Album.Photos.Select(photo => photo.LikedBy.Count()).Sum();

            NumAlbumLikesLabel.Text = totalAlbumLikes.ToString();

            return this;
        }

        private AlbumPhotosForm setAlbumToShow()
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
