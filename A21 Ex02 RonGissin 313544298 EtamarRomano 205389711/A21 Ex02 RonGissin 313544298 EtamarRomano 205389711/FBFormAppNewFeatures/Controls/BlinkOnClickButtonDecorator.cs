using FBAppCore.Validation;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class BlinkOnClickButtonDecorator : Button
    {
        private Button m_DecoratedButton;
        private Color m_OriginalButtonColor;
        private Color m_BlinkColor;
        private TimeSpan m_BlinkElapsedTime;

        public BlinkOnClickButtonDecorator(Button i_DecoratedButton, TimeSpan i_BlinkElapsedTime, Color i_BlinkColor) : base()
        {
            m_DecoratedButton = InputGuard.CheckNullArgument(i_DecoratedButton, nameof(i_DecoratedButton));
            m_BlinkElapsedTime = InputGuard.CheckNullArgument(i_BlinkElapsedTime, nameof(i_BlinkElapsedTime));
            m_BlinkColor = InputGuard.CheckNullArgument(i_BlinkColor, nameof(i_BlinkColor));
            m_OriginalButtonColor = m_DecoratedButton.BackColor; 
        }

        protected override void OnClick(EventArgs e)
        {
            m_DecoratedButton.BackColor = m_BlinkColor;
            Task.Delay(m_BlinkElapsedTime).ContinueWith(t => resetButtonColor());
            m_DecoratedButton.PerformClick();
        }

        private void resetButtonColor()
        {
            m_DecoratedButton.BackColor = m_OriginalButtonColor;
        }
    }
}
