using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Circle : Ellipse
    {
        private float diameter;

        public Circle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(x1, y1, x2, y2, color, fillColor, penWidth)
        {
            diameter = Math.Max(this.x2 - this.x1, this.y2 - this.y1);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, x1, y1, diameter, diameter);
            graphics.DrawEllipse(pen, x1, y1, diameter, diameter);
        }
    }
}
