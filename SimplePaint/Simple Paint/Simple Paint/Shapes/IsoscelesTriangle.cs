using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth)
        {
            Point vertex1 = new Point(start.X, start.Y);
            Point vertex2 = new Point(end.X, end.Y);
            Point vertex3 = new Point(start.X + (end.X - start.X) * 2, start.Y);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };
        }

        public IsoscelesTriangle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth)
        {
            Point vertex1 = new Point(x1, y1);
            Point vertex2 = new Point(x2, y2);
            Point vertex3 = new Point(x1 + (x2 - x1) * 2, y1);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };
        }

        public IsoscelesTriangle(Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth) { }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            Point vertex1 = new Point(start.X, start.Y);
            Point vertex2 = new Point(end.X, end.Y);
            Point vertex3 = new Point(start.X + (end.X - start.X) * 2, start.Y);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };

            graphics.FillPolygon(Brush, vertices);
            graphics.DrawPolygon(Pen, vertices);
        }
    }
}
