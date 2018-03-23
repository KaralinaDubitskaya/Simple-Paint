using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public abstract class Triangle : Shape
    {
        protected Point _startPoint;
        protected Point _endPoint;

        public Point[] Vertices { get; set; }
        public Brush Brush { get; set; }

        public Triangle(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            Brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(Brush, Vertices);
            graphics.DrawPolygon(Pen, Vertices);
        }
    }
}
