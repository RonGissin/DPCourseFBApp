using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FBAppUI.Controls
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs i_EventArgs)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(1, 1, ClientSize.Width - 4, ClientSize.Height - 4);
            this.Region = new Region(graphicsPath);
            base.OnPaint(i_EventArgs);
        }
    }
}
