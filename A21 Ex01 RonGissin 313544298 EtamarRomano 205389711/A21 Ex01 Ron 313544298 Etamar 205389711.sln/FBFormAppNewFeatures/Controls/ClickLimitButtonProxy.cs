using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class ClickLimitButtonProxy : Button
    {
        public int ClickThreshold { get; set; }

        public string PromptMessage { get; set; }

        public TimeSpan TimeToEnabled { get; set; }

        private int m_NumClicks;

        public ClickLimitButtonProxy() : base()
        {
            ClickThreshold = 2;
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
                Task.Delay(TimeToEnabled).ContinueWith(t => ResetButtonToEnabled());

                return;
            }

            base.OnClick(e);
        }

        private void ResetButtonToEnabled()
        {
            this.Invoke(new Action(() => Enabled = true));
        }
    }
}
