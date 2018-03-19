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
        private Point start;
        private Point end;

        public Line(Color color, float penWidth) : base(color, penWidth) {}

        public Line(Point startPoint, Point endPoint, Color color, float penWidth) : base(color, penWidth)
        {
            start = startPoint;
            end = endPoint;
        }

        public Line(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            start.X = x1;
            start.Y = y1;

            end.X = x2;
            end.Y = y2;
        }

        public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
        {
            start = startPoint;
            end = endPoint;

            graphics.DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }
    }
}
