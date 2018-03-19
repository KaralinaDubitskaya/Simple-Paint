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
        // Coordinates of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected Point leftPoint;

        // Coordinates of the lower-right corner of the bounding rectangle that defines the ellipse.
        protected Point rightPoint;

        public Brush Brush { get; set; }

        public Ellipse(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Brush = new SolidBrush(fillColor);
        }

        public Ellipse(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            leftPoint.X = Math.Min(start.X, end.X);
            leftPoint.Y = Math.Min(start.Y, end.Y);

            rightPoint.X = Math.Max(start.X, end.X);
            rightPoint.Y = Math.Max(start.Y, end.Y);
            
            Brush = new SolidBrush(fillColor);
        }

        public Ellipse(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            leftPoint.X = Math.Min(x1, x2);
            leftPoint.Y = Math.Min(y1, y2);

            rightPoint.X = Math.Max(x1, x2);
            rightPoint.Y = Math.Max(y1, y2);

            Brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            leftPoint.X = Math.Min(start.X, end.X);
            leftPoint.Y = Math.Min(start.Y, end.Y);

            rightPoint.X = Math.Max(start.X, end.X);
            rightPoint.Y = Math.Max(start.Y, end.Y);

            graphics.FillEllipse(Brush, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
            graphics.DrawEllipse(Pen, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
            graphics.DrawEllipse(Pen, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }
    }
}
