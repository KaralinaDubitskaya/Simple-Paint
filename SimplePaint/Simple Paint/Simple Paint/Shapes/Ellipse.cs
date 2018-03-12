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

        protected Brush brush;

        public Ellipse(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }

        public Ellipse(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            leftPoint.X = Math.Min(start.X, end.X);
            leftPoint.Y = Math.Min(start.Y, end.Y);

            rightPoint.X = Math.Max(start.X, end.X);
            rightPoint.Y = Math.Max(start.Y, end.Y);
            
            brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            leftPoint.X = Math.Min(start.X, end.X);
            leftPoint.Y = Math.Min(start.Y, end.Y);

            rightPoint.X = Math.Max(start.X, end.X);
            rightPoint.Y = Math.Max(start.Y, end.Y);

            graphics.FillEllipse(brush, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
            graphics.DrawEllipse(pen, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
            graphics.DrawEllipse(pen, leftPoint.X, leftPoint.Y, rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }
    }
}
