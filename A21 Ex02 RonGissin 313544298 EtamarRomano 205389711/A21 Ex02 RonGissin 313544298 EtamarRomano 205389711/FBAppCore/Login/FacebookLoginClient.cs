using FacebookWrapper;

namespace FBAppCore.Login
{
    public class FacebookLoginClient : ILoginClient
    {
        private string m_AppId;

        public FacebookLoginClient()
        {
            m_AppId = "367532597691434";
        }

        public LoginResult Login(params string[] i_Permissions)
        {
            return FacebookService.Login(m_AppId, i_Permissions);
        }

        public LoginResult Connect(string i_AccessToken)
        {
            return FacebookService.Connect(i_AccessToken);
        }
    }
}
