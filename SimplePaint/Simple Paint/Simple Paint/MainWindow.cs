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

        private int x1, y1;   // coordinates of the starting point
        private int x2, y2;   // coordinates of the endpoint
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

        private void CreateShapes()
        {
           
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
            x1 = e.X;
            y1 = e.Y;

            // end point is equal to starting point
            x2 = e.X;
            y2 = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawn)
            {
                x2 = e.X;
                y2 = e.Y;

                // redraw pictureBox
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            isDrawn = false;
        }
    }
}
