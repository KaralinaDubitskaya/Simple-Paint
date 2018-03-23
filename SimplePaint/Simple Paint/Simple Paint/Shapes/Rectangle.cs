using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Rectangle : Shape
    {
        public Brush Brush { get; set; }

        public Rectangle(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

            Brush = new SolidBrush(fillColor);
        }

        public Rectangle(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Brush = new SolidBrush(fillColor);
        }

        public Rectangle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;

            Brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            Point leftCorner = new Point(Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y));
            Point rightCorner = new Point(Math.Max(StartPoint.X, EndPoint.X), Math.Max(StartPoint.Y, EndPoint.Y));

            graphics.FillRectangle(Brush, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
            graphics.DrawRectangle(Pen, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }
    }
}
