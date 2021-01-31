using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppCore.Validation;

namespace FBAppUI.Forms
{
    public partial class BestFriendForm : Form, IDataInjectable
    {
        private User m_BestFriend;

        public BestFriendForm(User i_BestFriend)
        {
            m_BestFriend = InputGuard.CheckNullArgument(i_BestFriend, nameof(i_BestFriend));
            InitializeComponent();
            CenterToScreen();
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            base.OnShown(i_EventArgs);

            InjectData();
        }

        public void InjectData()
        {
            BestFriendFormLabel.Text = m_BestFriend.Name;
            BestFriendPictureBox.LoadAsync(m_BestFriend.PictureNormalURL);
            BestFriendPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
