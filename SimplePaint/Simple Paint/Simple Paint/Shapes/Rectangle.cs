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
        // Coordinates of the upper-left corner.
        protected Point leftCorner;

        // Coordinates of the lower-right corner.
        protected Point rightCorner;

        public Brush Brush { get; set; }

    public Rectangle(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            leftCorner.X = Math.Min(start.X, end.X);
            leftCorner.Y = Math.Min(start.Y, end.Y);

            rightCorner.X = Math.Max(start.X, end.X);
            rightCorner.Y = Math.Max(start.Y, end.Y);

            Brush = new SolidBrush(fillColor);
        }

        public Rectangle(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Brush = new SolidBrush(fillColor);
        }

        public Rectangle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            leftCorner.X = Math.Min(x1, x2);
            leftCorner.Y = Math.Min(y1, y2);

            rightCorner.X = Math.Max(x1, x2);
            rightCorner.Y = Math.Max(y1, y2);

            Brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            leftCorner.X = Math.Min(start.X, end.X);
            leftCorner.Y = Math.Min(start.Y, end.Y);

            rightCorner.X = Math.Max(start.X, end.X);
            rightCorner.Y = Math.Max(start.Y, end.Y);

            graphics.FillRectangle(Brush, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
            graphics.DrawRectangle(Pen, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
            graphics.DrawRectangle(Pen, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }
    }
}
