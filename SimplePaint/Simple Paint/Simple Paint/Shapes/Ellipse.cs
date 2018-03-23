using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Ellipse : Shape
    {
        public Brush Brush { get; set; }

        public Ellipse(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Brush = new SolidBrush(fillColor);
        }

        public Ellipse(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

            Brush = new SolidBrush(fillColor);
        }

        public Ellipse(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;

            Brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
            graphics.DrawEllipse(Pen, StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
        }
    }
}
