using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Ellipse: Shape
    {
        // Coordinates of the upper-left corner of the bounding rectangle that defines the ellipse.
        private int x1;
        private int y1;

        // Coordinates of the lower-right corner of the bounding rectangle that defines the ellipse.
        private int x2;
        private int y2;

        private Brush brush;

        public Ellipse(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth)
        {
            this.x1 = Math.Min(x1, x2);
            this.y1 = Math.Min(y1, y2);

            this.x2 = Math.Max(x1, x2);
            this.y2 = Math.Max(y1, y2);

            pen = new Pen(color, penWidth);
            brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, x1, y1, x2 - x1, y2 - y1);
            graphics.DrawEllipse(pen, x1, y1, x2 - x1, y2 - y1);
        }
    }
}
