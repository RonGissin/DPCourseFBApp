using FacebookWrapper;
using FBAppCore.AppSettings;
using FBAppCore.Login;
using FBAppCore.Validation;
using FBAppUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FBAppUI
{
    public class ApplicationFlowManager : FormAppManagerTemplate
    {
        private ILoginClient m_loginClient;
        private LoginForm m_LoginForm;
        private ApplicationForm m_ApplicationForm;
        private AppSettings m_AppSettings;

        public ApplicationFlowManager(ILoginClient i_LoginClient)
        {
            m_loginClient = InputGuard.CheckNullArgument(i_LoginClient, nameof(i_LoginClient));

            try
            {
                m_AppSettings = AppXmlSettingsHandler.Instance.LoadSettingsFromFile();
            }
            catch
            {
                useDefaultSettings();
            }
        }

        public override LoginResultData ConnectToUser()
            =>  m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken) ?
                    connectWithLastUser() :
                    showLoginForm();

        public override bool ShouldExitApp()
            => ApplicationFormResult == DialogResult.Cancel || 
            LoginFormResultData.LoginDialogResult == DialogResult.Cancel;

        public override DialogResult ShowApplicationForm(LoginResultData i_LoginResultData)
        {
            DialogResult dialogResult = DialogResult.OK;

            if (LoginFormResultData.LoginDialogResult == DialogResult.OK)
            {
                m_ApplicationForm = new ApplicationForm(LoginFormResultData, m_AppSettings);
                dialogResult = m_ApplicationForm.ShowDialog();
                m_ApplicationForm.Dispose();
            }

            return dialogResult;
        }

        private LoginResultData connectWithLastUser()
        {
            LoginResult loginResult = m_loginClient.Connect(m_AppSettings.LastAccessToken);

            return new LoginResultData
            {
                LoginDialogResult = DialogResult.OK,
                AccessToken = loginResult.AccessToken,
                User = loginResult.LoggedInUser
            };
        }

        private LoginResultData showLoginForm()
        {
            DialogResult dialogResult = DialogResult.Retry;

            while (dialogResult == DialogResult.Retry)
            {
                m_LoginForm = new LoginForm(m_loginClient);
                dialogResult = m_LoginForm.ShowDialog();
                m_LoginForm.Dispose();
            }

            LoginResultData loginResultData = new LoginResultData
            {
                LoginDialogResult = m_LoginForm.DialogResult,
                AccessToken = m_LoginForm.AccessToken,
                User = m_LoginForm.User
            };

            return loginResultData;
        }

        private void useDefaultSettings()
        {
            m_AppSettings = new AppSettings()
            {
                LastWindowSize = new Size(900, 700),
                LastAccessToken = string.Empty,
                RememberUser = false
            };
        }
    }
}
