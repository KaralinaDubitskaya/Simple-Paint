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
        public Line(Color color, float penWidth) : base(color, penWidth) {}

        public Line(Point startPoint, Point endPoint, Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(x1, y1);
            Point endPoint = new Point(x2, y2);

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}
