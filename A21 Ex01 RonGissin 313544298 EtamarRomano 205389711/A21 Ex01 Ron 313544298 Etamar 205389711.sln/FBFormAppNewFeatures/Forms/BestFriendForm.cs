using FacebookWrapper.ObjectModel;
using FBAppInfra.Validation;
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
            CenterToScreen();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            InjectUserData();
        }

        private void InjectUserData()
        {
            BestFriendFormLabel.Text = m_BestFriend.Name;
            BestFriendPictureBox.LoadAsync(m_BestFriend.PictureNormalURL);
            BestFriendPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
