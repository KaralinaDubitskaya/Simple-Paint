using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Square : Rectangle
    {
        private float width;

        public Square(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(x1, y1, x2, y2, color, fillColor, penWidth)
        {
            width = Math.Max(this.x2 - this.x1, this.y2 - this.y1);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(brush, x1, y1, width, width);
            graphics.DrawRectangle(pen, x1, y1, width, width);
        }
    }
}
