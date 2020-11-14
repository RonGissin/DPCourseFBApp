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
    public partial class BestFriendForm : Form
    {
        private User m_BestFriend;
        public BestFriendForm(User i_BestFriend)
        {
            m_BestFriend = InputGuard.CheckNullArgument(i_BestFriend, nameof(i_BestFriend));
            InitializeComponent();
            InjectUserData();
            CenterToScreen();
        }

        private void InjectUserData()
        {
            BestFriendFormLabel.Text = m_BestFriend.Name;
            BestFriendPictureBox.LoadAsync(m_BestFriend.PictureNormalURL);
            BestFriendPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
