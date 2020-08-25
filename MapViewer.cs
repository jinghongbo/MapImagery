using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapImagery
{
    public partial class MapViewer : UserControl
    {

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            using (var graphics = this.CreateGraphics())
            { 
                graphics.DrawString("Mouse Wheel", SystemFonts.DefaultFont, Brushes.Red, 0, 0);
            }
            base.OnMouseWheel(e);
        }

     

        protected override void OnMouseDown(MouseEventArgs e)
        {
            using (var graphics = this.CreateGraphics())
            {
                graphics.DrawString("Mouse Down", SystemFonts.DefaultFont, Brushes.Red, 0, 0);
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            using (var graphics = this.CreateGraphics())
            {
                graphics.DrawString("Mouse Move", SystemFonts.DefaultFont, Brushes.Red, 0, 0);
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            using (var graphics = this.CreateGraphics())
            {
                graphics.DrawString("Mouse Up", SystemFonts.DefaultFont, Brushes.Red, 0, 0);
            }
            base.OnMouseUp(e);
        }
    }
}
