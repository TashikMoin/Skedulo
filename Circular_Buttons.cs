using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace CRUD_Operations_On_A_Desktop_Application
{
    class Circular_Buttons:Button
    {
        protected override void OnPaint(PaintEventArgs Control)
        {
            GraphicsPath Graphic_Path = new GraphicsPath();
            Graphic_Path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(Graphic_Path);
            base.OnPaint(Control);
        }
    }
}
