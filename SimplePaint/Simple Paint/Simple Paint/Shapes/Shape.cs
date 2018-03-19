using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public abstract class Shape
    {
        public Pen Pen { get; set; }

        public Shape(Color color, float penWidth)
        {
            Pen = new Pen(color, penWidth);
        }

        public abstract void Draw(Graphics graphics);
        public abstract void Draw(Graphics graphics, Point startPoint, Point endPoint);
    }
}
