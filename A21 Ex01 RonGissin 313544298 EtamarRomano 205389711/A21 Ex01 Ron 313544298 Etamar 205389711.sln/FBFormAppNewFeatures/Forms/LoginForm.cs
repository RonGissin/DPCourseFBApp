using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBAppCore.Login;
using FBAppInfra.Validation;
using System;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public partial class LoginForm : Form
    {
        private readonly ILoginClient r_LoginClient;
        private readonly string[] m_Permissions = {
            "public_profile",
            // "email",
            // "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            // "user_videos",
            // "publish_to_groups",
            // "groups_access_member_info",
            "user_friends",
            // "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
        };

        public User User { get; set; }

        public string AccessToken { get; set; }

        public LoginForm(ILoginClient loginClient)
        {
            r_LoginClient = InputGuard.CheckNullArgument(loginClient, nameof(loginClient));
            InitializeComponent();
            CenterToScreen();
        }

        private void LoginWithFacebookButton_Click(object sender, EventArgs e)
        {
            ExecuteFullLogin();
        }

        private void ExecuteFullLogin()
        {
            LoginResult loginResult = r_LoginClient.Login(m_Permissions);
            User = loginResult.LoggedInUser;
            AccessToken = loginResult.AccessToken;
            LoginResult connectResult = r_LoginClient.Connect(AccessToken);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
