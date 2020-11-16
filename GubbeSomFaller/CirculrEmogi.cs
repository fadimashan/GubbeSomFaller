using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GubbeSomFaller
{
    public class CirculrEmogi: PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();

            SolidBrush brush = new SolidBrush(Color.Yellow);

            g.AddEllipse(0,0, ClientSize.Width , ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            
            base.OnPaint(e);

        }
    }
}
