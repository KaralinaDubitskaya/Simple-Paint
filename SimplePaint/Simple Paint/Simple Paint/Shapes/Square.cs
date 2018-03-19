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
        // TODO coordinates calc
        private float width;

        public Square(Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth) { }

        public Square(Point start, Point end, Color color, Color fillColor, float penWidth) : base(start, end, color, fillColor, penWidth)
        {
            width = Math.Max(rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }

        public Square(int x1, int y1, int x2, int y2, Color color, Color fillColor, float penWidth) : base(x1, y1, x2, y2, color, fillColor, penWidth)
        {
            width = Math.Max(rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(brush, leftCorner.X, leftCorner.Y, width, width);
            graphics.DrawRectangle(pen, leftCorner.X, leftCorner.Y, width, width);
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            leftCorner.X = Math.Min(start.X, end.X);
            leftCorner.Y = Math.Min(start.Y, end.Y);

            rightCorner.X = Math.Max(start.X, end.X);
            rightCorner.Y = Math.Max(start.Y, end.Y);

            width = Math.Max(rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);

            graphics.FillRectangle(brush, leftCorner.X, leftCorner.Y, width, width);
            graphics.DrawRectangle(pen, leftCorner.X, leftCorner.Y, width, width);
        }
    }
}
