using FBAppCore.Validation;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class TextChangeButtonDecorator : Button
    {
        private Button m_DecoratedButton;
        private string m_OriginalButtonText;
        private string m_BlinkButtonText;
        private TimeSpan m_BlinkElapsedTime;

        public TextChangeButtonDecorator(Button i_DecoratedButton, TimeSpan i_BlinkElapsedTime, string i_BlinkText) : base()
        {
            m_DecoratedButton = InputGuard.CheckNullArgument(i_DecoratedButton, nameof(i_DecoratedButton));
            m_BlinkElapsedTime = InputGuard.CheckNullArgument(i_BlinkElapsedTime, nameof(i_BlinkElapsedTime));
            m_BlinkButtonText = InputGuard.CheckNullArgument(i_BlinkText, nameof(i_BlinkText));
            m_OriginalButtonText = m_DecoratedButton.Text;
        }

        protected override void OnClick(EventArgs e)
        {
            m_DecoratedButton.Text = m_BlinkButtonText;
            Task.Delay(m_BlinkElapsedTime).ContinueWith(t => resetButtonColor());
            m_DecoratedButton.PerformClick();
        }

        private void resetButtonColor()
        {
            m_DecoratedButton.Text = m_OriginalButtonText;
        }
    }
}