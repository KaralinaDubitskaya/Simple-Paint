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

        public int Count { get { return listOfShapes.Count; } } 

        public ListOfShapes()
        {
            listOfShapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            listOfShapes.Add(shape);
        }

        public Shape GetLast()
        {
            if (Count != 0)
            {
                return listOfShapes[Count - 1];
            }
            else
            {
                return null;
            }
        }

        public void Draw(Graphics graphics)
        {
            foreach (Shape shape in listOfShapes)
            {
                if (shape != null)
                    shape.Draw(graphics);
            }
        }

        public void Clear()
        {
            listOfShapes.Clear();
        }

        public void Remove(int index)
        {
            listOfShapes.RemoveAt(index);
        }

        public Shape Pop()
        {
            if (this.Count != 0)
            {
                Shape shape = listOfShapes[this.Count - 1];
                this.Remove(this.Count - 1);
                return shape;
            }
            else
                return null;
        }
    }
}
