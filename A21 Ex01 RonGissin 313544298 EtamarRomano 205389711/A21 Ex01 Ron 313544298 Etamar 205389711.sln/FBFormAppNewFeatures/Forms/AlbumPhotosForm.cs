using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppCore.ThreadingUtils;
using FBAppCore.Validation;

namespace FBAppUI.Forms
{
    public partial class AlbumPhotosForm : Form, IDataInjectable
    {
        private Album m_Album;
        private ImageForm m_ImageForm;
        private ApplicationLogicHandler m_LogicHandler;
        private ThreadRunner m_ThreadRunner;

        public AlbumPhotosForm(Album i_Album)
        {
            m_LogicHandler = ApplicationLogicHandler.Instance;
            m_Album = InputGuard.CheckNullArgument(i_Album, nameof(i_Album));
            m_ThreadRunner = new ThreadRunner();
            this.Text = m_Album.Name;
            InitializeComponent();
            CenterToScreen();
        }

        public void InjectData()
        {
            List<Action> methodsToRun = new List<Action>
            {
                setAlbumToShow,
                showAlbumLikes,
                showAlbumLocation,
                showAlbumDescription,
                showAlbumTags
            };

            m_ThreadRunner.RunMethodsAsSeperateThreads(methodsToRun);
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

        private void showAlbumDescription()
        {
            AlbumDescriptionData.Invoke(new Action(() => AlbumDescriptionData.Text = m_Album.Description));
        }

        private void showAlbumLocation()
        {
            AlbumLocationData.Invoke(new Action(() => AlbumLocationData.Text = m_Album.Location));
        }

        private void showAlbumTags()
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
                        AlbumTagsListBox.Invoke(new Action(() => AlbumTagsListBox.Items.Add(taggedUser)));
                    }
                }
            }
            catch
            {
            }
        }

        private void showAlbumLikes()
        {
            int totalAlbumLikes = m_Album.Photos.Select(photo => photo.LikedBy.Count()).Sum();

            NumAlbumLikesLabel.Invoke(new Action(() => NumAlbumLikesLabel.Text = totalAlbumLikes.ToString()));
        }

        private void setAlbumToShow()
        {
            AlbumPhotosListView.Invoke(new Action(() => AlbumPhotosListView.SetGrid(m_Album.Photos)));
            this.Invoke(new Action(() => Text = m_Album.Name));
        }

        private void showPhotoForm()
        {
            var item = AlbumPhotosListView.SelectedItems[0];
            Photo photoToShow = m_Album.Photos.ElementAt(item.ImageIndex);

            m_ImageForm = new ImageForm(photoToShow);
            m_ImageForm.ShowDialog();
            m_ImageForm.Dispose();
        }
    }
}
