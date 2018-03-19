using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Simple_Paint
{
    public partial class MainWindow : Form
    {
        private ListOfShapes listOfShapes;
        private ListOfShapes redoList;
        
        private Shape shape;

        private Color color;
        private Color fillColor;

        private float penWidth;

        private Point startPoint;   // coordinates of the starting point
        private Point endPoint;   // coordinates of the endpoint
        private bool isDrawn; // true, when the user is drawing a shape

        private string fileName;

        private const int REDO_BUFFER_SIZE = 20;

        public MainWindow()
        {
            InitializeComponent();

            btnColor.BackColor = Color.Black;
            btnFillColor.BackColor = Color.White;
            
            listOfShapes = new ListOfShapes();
            redoList = new ListOfShapes();

            color = Color.Black;
            fillColor = Color.White;
            penWidth = 1;

            isDrawn = false;

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                color = colorDialog.Color;

                shape.Pen = new Pen(color, penWidth);
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnFillColor.BackColor = colorDialog.Color;
                fillColor = colorDialog.Color;
                
                if (!(shape is Line))
                {
                    object[] args = new object[3] { color, fillColor, penWidth };
                    shape = (Shape)Activator.CreateInstance(shape.GetType(), args);
                }
            }
        }

        private void penSize_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)penSize.Value;
            shape.Pen = new Pen(color, penWidth);
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
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                isDrawn = false;

                listOfShapes.Add(shape);

                // create new instance of shape
                object[] args;
                if (shape is Line)
                {
                    args = new object[2] { color, penWidth };
                }
                else
                {
                    args = new object[3] { color, fillColor, penWidth };
                }
                shape = (Shape)Activator.CreateInstance(shape.GetType(), args);
            }
        }

        #region btnShape_Click
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
        #endregion

        // occurs when the control is redrawn
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            listOfShapes.Draw(e.Graphics);
            if ((shape != null) && isDrawn)
            {
                shape.Draw(e.Graphics, startPoint, endPoint);
            }
        }

        // draw demo-picture 
        private void btnDemo_Click(object sender, EventArgs e)
        {
            // grass
            Shape sh = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height, Color.LightGreen, Color.LightGreen, 1);
            listOfShapes.Add(sh);

            // sky
            sh = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height / 2, Color.SkyBlue, Color.SkyBlue, 1);
            listOfShapes.Add(sh);

            // left cloud
            sh = new Ellipse(87, 78, 188, 111, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(148, 89, 225, 126, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(134, 72, 197, 104, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(107, 94, 179, 133, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(155, 89, 212, 118, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(107, 89, 163, 116, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);

            // right cloud
            sh = new Ellipse(587, 98, 688, 131, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(648, 109, 725, 146, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(634, 92, 697, 124, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(607, 114, 679, 153, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(655, 109, 712, 138, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);
            sh = new Ellipse(607, 109, 663, 136, Color.WhiteSmoke, Color.White, 1);
            listOfShapes.Add(sh);

            // house
            sh = new Square(250, 227, 463, 462, Color.Black, Color.Tan, 2);
            listOfShapes.Add(sh);

            // left window
            sh = new Square(284, 308, 336, 336, Color.Sienna, Color.LightCyan, 3);
            listOfShapes.Add(sh);

            sh = new Line(335, 336, 285, 336, Color.Navy, 1);
            listOfShapes.Add(sh);

            sh = new Line(311, 359, 311, 309, Color.Navy, 1);
            listOfShapes.Add(sh);

            // right window
            sh = new Square(384, 308, 436, 336, Color.Sienna, Color.LightCyan, 3);
            listOfShapes.Add(sh);

            sh = new Line(435, 336, 385, 336, Color.Navy, 1);
            listOfShapes.Add(sh);

            sh = new Line(411, 359, 411, 309, Color.Navy, 1);
            listOfShapes.Add(sh);

            // roof
            sh = new IsoscelesTriangle(212, 225, 363, 144, Color.Black, Color.SaddleBrown, 2);
            listOfShapes.Add(sh);

            sh = new Rectangle(195, 220, 533, 238, Color.Black, Color.SaddleBrown, 2);
            listOfShapes.Add(sh);

            // door
            sh = new Rectangle(341, 391, 396, 462, Color.Black, Color.SaddleBrown, 2);
            listOfShapes.Add(sh);

            sh = new Line(388, 432, 376, 432, Color.Black, 1);
            listOfShapes.Add(sh);

            // circle window
            sh = new Circle(347, 178, 377, 191, Color.Black, Color.BurlyWood, 2);
            listOfShapes.Add(sh);

            sh = new Circle(356, 186, 358, 199, Color.Black, Color.AliceBlue, 2);
            listOfShapes.Add(sh);

            // chimney
            sh = new Rectangle(430, 156, 454, 201, Color.Black, Color.BurlyWood, 2);
            listOfShapes.Add(sh);

            sh = new Rectangle(418, 142, 467, 163, Color.Black, Color.BurlyWood, 2);
            listOfShapes.Add(sh);

            // tree
            sh = new Rectangle(831, 265, 852, 469, Color.BurlyWood, Color.BurlyWood, 1);
            listOfShapes.Add(sh);

            sh = new Line(938, 265, 848, 360, Color.BurlyWood, 6);
            listOfShapes.Add(sh);

            sh = new Line(779, 265, 840, 375, Color.BurlyWood, 6);
            listOfShapes.Add(sh);

            sh = new Ellipse(754, 168, 924, 278, Color.DarkGreen, Color.ForestGreen, 1);
            listOfShapes.Add(sh);

            sh = new Ellipse(924, 279, 924, 284, Color.DarkGreen, Color.ForestGreen, 1);
            listOfShapes.Add(sh);

            sh = new Ellipse(884, 225, 997, 342, Color.DarkGreen, Color.ForestGreen, 1);
            listOfShapes.Add(sh);

            sh = new Ellipse(730, 230, 854, 353, Color.DarkGreen, Color.ForestGreen, 1);
            listOfShapes.Add(sh);

            sh = new Ellipse(840, 228, 937, 333, Color.DarkGreen, Color.ForestGreen, 1);
            listOfShapes.Add(sh);

            // redraw pictureBox
            pictureBox.Refresh();
        }

        // clear pictureBox
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;

            listOfShapes.Clear();
            redoList.Clear();
        }

        // open file
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Image Files(*.jpg; *.bmp; *.png)| *.jpg; *.bmp; *.png";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = (Image)Image.FromFile(openFileDialog.FileName).Clone();
                    fileName = String.Copy(openFileDialog.FileName);
                }

                catch (Exception exception)
                {
                    MessageBox.Show("Error: Could not open file. Original error: " + exception.Message);
                }
            }

            listOfShapes.Clear();
            redoList.Clear();
        }
        
        // undo 
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem.Enabled = true;

            if (redoList.Count > REDO_BUFFER_SIZE)
            {
                redoList.Remove(0);
            }
            redoList.Add(listOfShapes.Pop());

            pictureBox.Refresh();

            if (listOfShapes.Count == 0)
            {
                undoToolStripMenuItem.Enabled = false;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfShapes.Add(redoList.Pop());

            pictureBox.Refresh();

            if (redoList.Count == 0)
            {
                redoToolStripMenuItem.Enabled = false;
            }

            undoToolStripMenuItem.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Object-oriented programming\n\n\"Simple paint\"\nCreated by Karolina Dubitskaya, gr. 651001\n\nMinsk, 2018", "Simple paint - Lab. work #1-2");
        }

        // TODO hot keys
        // TODO images
    }
}
