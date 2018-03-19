using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class Circle : Ellipse
    {
        // TODO coordinates calc
        private float diameter;

        public Circle(Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth) { }

        public Circle(Point start, Point end, Color color, Color fillColor, float penWidth) : base(start, end, color, fillColor, penWidth)
        {
            diameter = Math.Max(rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }

        public Circle(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(x1, y1, x2, y2, color, fillColor, penWidth)
        {
            diameter = Math.Max(rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, leftPoint.X, leftPoint.Y, diameter, diameter);
            graphics.DrawEllipse(pen, leftPoint.X, leftPoint.Y, diameter, diameter);
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            leftPoint.X = Math.Min(start.X, end.X);
            leftPoint.Y = Math.Min(start.Y, end.Y);

            rightPoint.X = Math.Max(start.X, end.X);
            rightPoint.Y = Math.Max(start.Y, end.Y);

            diameter = Math.Max(rightPoint.X - leftPoint.X, rightPoint.Y - leftPoint.Y);

            graphics.FillEllipse(brush, leftPoint.X, leftPoint.Y, diameter, diameter);
            graphics.DrawEllipse(pen, leftPoint.X, leftPoint.Y, diameter, diameter);
        }
    }
}
