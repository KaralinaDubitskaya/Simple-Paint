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
        protected Pen pen;
        public abstract void Draw(Graphics graphics);
    }
}
