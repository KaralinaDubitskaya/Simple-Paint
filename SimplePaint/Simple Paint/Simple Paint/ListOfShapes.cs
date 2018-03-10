using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class ListOfShapes
    {
        private List<Shape> listOfShapes;

        public ListOfShapes()
        {
            listOfShapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            listOfShapes.Add(shape);
        }

        public void Draw(Graphics graphics)
        {
            foreach (Shape shape in listOfShapes)
            {
                shape.Draw(graphics);
            }
        }
    }
}
