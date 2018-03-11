using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public abstract class Triangle: Shape
    {
        protected Point[] vertices;
        protected Brush brush;

        public Triangle(Color color, Color fillColor, float penWidth)
        {
            pen = new Pen(color, penWidth);
            brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(brush, vertices);
            graphics.DrawPolygon(pen, vertices);
        }
    }
}
