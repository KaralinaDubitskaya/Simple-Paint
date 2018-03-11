using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth)
        {
            Point vertex1 = new Point(x1, y1);
            Point vertex2 = new Point(x2, y2);
            Point vertex3 = new Point(x1, y2);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };
        }
    }
}
