using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Line : Shape
    {
        // Coordinates of the Line start point.
        private int x1;
        private int y1;

        // Coordinates of the Line end point.
        private int x2;
        private int y2;

        public Line(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            this.x1 = x1;
            this.y1 = y1;
            
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
