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
        public Square(Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth) { }

        public Square(Point start, Point end, Color color, Color fillColor, float penWidth) 
            : base(start, end, color, fillColor, penWidth) { }

        public Square(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) 
            : base(x1, y1, x2, y2, color, fillColor, penWidth) { }

        public override void Draw(Graphics graphics)
        {
            Point startPoint = new Point(Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y));
            Point endPoint = new Point(Math.Max(StartPoint.X, EndPoint.X), Math.Max(StartPoint.Y, EndPoint.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

            float width = Math.Max(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);

            graphics.FillRectangle(Brush, StartPoint.X, StartPoint.Y, width, width);
            graphics.DrawRectangle(Pen, StartPoint.X, StartPoint.Y, width, width);
        }
    }
}
