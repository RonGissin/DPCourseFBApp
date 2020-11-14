using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public partial class LoginForm : Form
    {
        private readonly ILoginClient r_loginClient;

        public User User { get; set; }

        public string AccessToken { get; set; }

        public LoginForm(ILoginClient loginClient)
        {
            r_loginClient = InputGuard.CheckNullArgument(loginClient, nameof(loginClient));
            InitializeComponent();
            CenterToScreen();
        }

        private void LoginWithFacebookButton_Click(object sender, EventArgs e)
        {
            string[] permissions = {
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
            };
            
            LoginResult loginResult = r_loginClient.Login(permissions);
            User = loginResult.LoggedInUser;
            AccessToken = loginResult.AccessToken;
            LoginResult connectResult = r_loginClient.Connect(AccessToken);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
