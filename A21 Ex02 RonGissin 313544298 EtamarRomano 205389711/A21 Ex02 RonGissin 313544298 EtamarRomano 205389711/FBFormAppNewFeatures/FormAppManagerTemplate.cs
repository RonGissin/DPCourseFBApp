using System.Windows.Forms;
using FBAppCore.Login;

namespace FBAppUI
{
    public abstract class FormAppManagerTemplate
    {
        public bool ExitSignal { get; set; }

        public LoginResultData LoginFormResultData { get; private set; }

        public DialogResult ApplicationFormResult { get; private set; }

        public void RunApplication()
        {
            while (!ExitSignal)
            {
                LoginFormResultData = ConnectToUser();
                ApplicationFormResult = ShowApplicationForm(LoginFormResultData);
                ExitSignal = ShouldExitApp();
            }
        }

        public abstract LoginResultData ConnectToUser();

        public abstract DialogResult ShowApplicationForm(LoginResultData i_LoginResultData);

        public abstract bool ShouldExitApp();
    }
}
