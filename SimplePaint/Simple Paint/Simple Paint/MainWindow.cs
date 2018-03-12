using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Paint
{
    public partial class MainWindow : Form
    {
        private Graphics graphics;
        private ListOfShapes listOfShapes;

        private Shape shape;

        private Color color;
        private Color fillColor;

        private float penWidth;

        private Point startPoint;   // coordinates of the starting point
        private Point endPoint;   // coordinates of the endpoint
        private bool isDrawn; // true, when the user is drawing a shape

        public MainWindow()
        {
            InitializeComponent();

            btnColor.BackColor = Color.Black;
            btnFillColor.BackColor = Color.White;

            graphics = CreateGraphics(pictureBox.Width, pictureBox.Height);
            listOfShapes = new ListOfShapes();

            color = Color.Black;
            fillColor = Color.White;
            penWidth = 1;

            isDrawn = false;
            
        }

        private Graphics CreateGraphics(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            pictureBox.Image = bitmap;
            return Graphics.FromImage(bitmap);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                color = colorDialog.Color;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnFillColor.BackColor = colorDialog.Color;
                fillColor = colorDialog.Color;
            }
        }

        private void penSize_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)penSize.Value;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // user starts drawing
            isDrawn = true;

            // coordinates of the starting point
            startPoint.X = e.X;
            startPoint.Y = e.Y;

            // end point is equal to starting point
            endPoint.X = e.X;
            endPoint.Y = e.Y;
        }
        
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawn)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                // redraw pictureBox
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint.X = e.X;
            endPoint.Y = e.Y;

            isDrawn = false;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shape = new Line(color, penWidth);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shape = new Ellipse(color, fillColor, penWidth);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shape = new Circle(color, fillColor, penWidth);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shape = new Rectangle(color, fillColor, penWidth);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            shape = new Square(color, fillColor, penWidth);
        }

        private void btnIsoscelesTriangle_Click(object sender, EventArgs e)
        {
            shape = new IsoscelesTriangle(color, fillColor, penWidth);
        }

        private void btnRightTriangle_Click(object sender, EventArgs e)
        {
            shape = new RightTriangle(color, fillColor, penWidth);
        }

        // occurs when the control is redrawn
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.Draw(e.Graphics, startPoint, endPoint);
            }
        }
        // TODO save & open
        // TODO undo & redo
        // TODO cat
        // TODO save figure
        // TODO change penWidth
    }
}
