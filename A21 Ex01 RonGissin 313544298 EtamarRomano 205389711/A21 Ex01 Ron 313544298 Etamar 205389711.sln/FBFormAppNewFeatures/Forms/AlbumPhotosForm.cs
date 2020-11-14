using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBFormAppNewFeatures.Forms
{
    public partial class AlbumPhotosForm : Form
    {
        private Album m_Album;

        public AlbumPhotosForm(Album i_Album)
        {
            m_Album = InputGuard.CheckNullArgument(i_Album, nameof(i_Album));
            Text = m_Album.Name;
            InitializeComponent();
            CenterToScreen();
            SetAlbumToShow().WithAlbumLikes().WithAlbumTags().WithAlbumLocation().WithAlbumDescription();
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
            IEnumerable<string> taggedUsers = m_Album.Photos.SelectMany(photo => photo.Tags?.Select(tag => tag.User.Name));

            if(taggedUsers != null)
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
            return this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
