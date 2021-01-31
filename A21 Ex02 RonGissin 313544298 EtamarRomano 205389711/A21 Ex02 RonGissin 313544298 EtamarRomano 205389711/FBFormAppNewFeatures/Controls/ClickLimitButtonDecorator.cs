using FBAppCore.Validation;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class ClickLimitButtonDecorator : Button
    {
        public int ClickThreshold { get; set; } = 2;

        public string PromptMessage { get; set; }

        public TimeSpan TimeToEnabled { get; set; }

        private int m_NumClicks;

        private Button m_DecoratedButton;

        public ClickLimitButtonDecorator(Button i_DecoratedButton) : base()
        {
            m_DecoratedButton = InputGuard.CheckNullArgument(i_DecoratedButton, nameof(i_DecoratedButton));
            TimeToEnabled = new TimeSpan(0, 0, 15);
            PromptMessage = $"Button Disabled and will be enabled again in {TimeToEnabled} hours. If you wish to have unlimited usage, upgrade to premium.";
            m_NumClicks = 0;
        }

        protected override void OnClick(EventArgs e)
        {
            m_NumClicks++;

            if(m_NumClicks == ClickThreshold)
            {
                m_NumClicks = 0;
                this.Enabled = false;
                MessageBox.Show(PromptMessage);
                Task.Delay(TimeToEnabled).ContinueWith(t => resetButtonToEnabled());

                return;
            }

            m_DecoratedButton.PerformClick();
        }

        private void resetButtonToEnabled()
        {
            this.Invoke(new Action(() => Enabled = true));
        }
    }
}
