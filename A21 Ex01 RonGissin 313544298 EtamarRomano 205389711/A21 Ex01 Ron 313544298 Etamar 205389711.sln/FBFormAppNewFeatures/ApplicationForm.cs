using FacebookWrapper;
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

namespace FBFormAppNewFeatures
{
    public partial class ApplicationForm : Form
    {
        private FacebookObjectCollection<Group> m_Groups;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<User> m_Friends;
        
        private User m_User;

        public ApplicationForm(User i_loggedInUser, string i_AccessToken)
        {
            InitializeComponent();
            m_User = i_loggedInUser;
            m_Groups = m_User.Groups;
            m_Albums = m_User.Albums;
            m_Friends = m_User.Friends;

            fetchAlbumsListBox();
            fetchFriendsListBox();
            fetchGroupsListBox();
            fetchProfilePicture();
        }

        private void fetchProfilePicture()
        {
            ProfilePictureBox.LoadAsync(m_User.PictureNormalURL);
        }

        private void fetchAlbumsListBox()
        {
            AlbumsListBox.Items.Clear();
            AlbumsListBox.DisplayMember = nameof(Album.Name);

            foreach (Album album in m_Albums)
            {
                AlbumsListBox.Items.Add(album);
            }
        }

        private void fetchFriendsListBox()
        {
            FriendsListBox.Items.Clear();
            FriendsListBox.DisplayMember = nameof(User.Name);

            foreach (User friend in m_Friends)
            {
                FriendsListBox.Items.Add(friend);
            }
        }

        private void fetchGroupsListBox()
        {
            GroupsListBox.Items.Clear();
            GroupsListBox.DisplayMember = nameof(Group.Name);

            foreach (Group group in m_Groups)
            {
                GroupsListBox.Items.Add(group);
            }
        }
    }
}
