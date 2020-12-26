using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class ClickLimitButtonProxy : Button
    {
        public int ClickThreshold { get; set; }

        public string PromptMessage { get; set; }

        public int HoursToEnabled { get; set; }

        private int m_NumClicks;

        public ClickLimitButtonProxy() : base()
        {
            ClickThreshold = 1;
            HoursToEnabled = 12;
            PromptMessage = $"Button Disabled and will be enabled again in {HoursToEnabled} hours. If you wish to have unlimited usage, upgrade to premium.";
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
                Task.Delay(new TimeSpan(HoursToEnabled, 0, 0)).ContinueWith(t => ResetButtonToEnabled());
            }

            base.OnClick(e);
        }

        private void ResetButtonToEnabled()
        {
            this.Invoke(new Action(() => Enabled = true));
        }
    }
}
