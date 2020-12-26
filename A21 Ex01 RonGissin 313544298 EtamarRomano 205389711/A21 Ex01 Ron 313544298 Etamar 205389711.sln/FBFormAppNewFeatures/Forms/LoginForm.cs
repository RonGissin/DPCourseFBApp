using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBAppCore.Login;
using FBAppCore.Validation;

namespace FBAppUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ILoginClient r_LoginClient;
        private readonly string[] r_Permissions = 
        {
            "public_profile",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_friends",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
        };

        public User User { get; set; }

        public string AccessToken { get; set; }

        public LoginForm(ILoginClient i_LoginClient)
        {
            r_LoginClient = InputGuard.CheckNullArgument(i_LoginClient, nameof(i_LoginClient));
            InitializeComponent();
            CenterToScreen();
        }

        private void loginWithFacebookButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            executeFullLogin();
        }

        private void executeFullLogin()
        {
            LoginResult loginResult = r_LoginClient.Login(r_Permissions);

            this.User = loginResult.LoggedInUser;
            this.AccessToken = loginResult.AccessToken;
            LoginResult connectResult = r_LoginClient.Connect(AccessToken);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
