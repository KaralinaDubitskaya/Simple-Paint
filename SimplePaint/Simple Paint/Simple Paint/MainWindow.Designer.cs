namespace Simple_Paint
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.penSize = new System.Windows.Forms.NumericUpDown();
            this.btnDemo = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnIsoscelesTriangle = new System.Windows.Forms.Button();
            this.btnRightTriangle = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1146, 28);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "Open...";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1060, 575);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnColor.Location = new System.Drawing.Point(10, 356);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(43, 43);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFillColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnFillColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFillColor.Location = new System.Drawing.Point(10, 431);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(43, 43);
            this.btnFillColor.TabIndex = 5;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 336);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(7, 411);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(62, 17);
            this.lblFillColor.TabIndex = 7;
            this.lblFillColor.Text = "Fill Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pen Size";
            // 
            // penSize
            // 
            this.penSize.Location = new System.Drawing.Point(10, 504);
            this.penSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.penSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSize.Name = "penSize";
            this.penSize.ReadOnly = true;
            this.penSize.Size = new System.Drawing.Size(43, 22);
            this.penSize.TabIndex = 9;
            this.penSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSize.ValueChanged += new System.EventHandler(this.penSize_ValueChanged);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDemo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnDemo.Image = global::Simple_Paint.Properties.Resources.demo;
            this.btnDemo.Location = new System.Drawing.Point(10, 552);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(42, 40);
            this.btnDemo.TabIndex = 10;
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnLine.Image = global::Simple_Paint.Properties.Resources.line;
            this.btnLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLine.Location = new System.Drawing.Point(11, 32);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(43, 43);
            this.btnLine.TabIndex = 12;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnEllipse.Image = global::Simple_Paint.Properties.Resources.ellipse;
            this.btnEllipse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEllipse.Location = new System.Drawing.Point(11, 74);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(43, 43);
            this.btnEllipse.TabIndex = 13;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnCircle.Image = global::Simple_Paint.Properties.Resources.circle;
            this.btnCircle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCircle.Location = new System.Drawing.Point(11, 116);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(43, 43);
            this.btnCircle.TabIndex = 14;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnRectangle.Image = global::Simple_Paint.Properties.Resources.rectangle;
            this.btnRectangle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRectangle.Location = new System.Drawing.Point(11, 158);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(43, 43);
            this.btnRectangle.TabIndex = 15;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSquare.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnSquare.Image = global::Simple_Paint.Properties.Resources.square;
            this.btnSquare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSquare.Location = new System.Drawing.Point(11, 200);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(43, 43);
            this.btnSquare.TabIndex = 16;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnIsoscelesTriangle
            // 
            this.btnIsoscelesTriangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIsoscelesTriangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnIsoscelesTriangle.Image = global::Simple_Paint.Properties.Resources.triangle;
            this.btnIsoscelesTriangle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIsoscelesTriangle.Location = new System.Drawing.Point(11, 242);
            this.btnIsoscelesTriangle.Name = "btnIsoscelesTriangle";
            this.btnIsoscelesTriangle.Size = new System.Drawing.Size(43, 43);
            this.btnIsoscelesTriangle.TabIndex = 17;
            this.btnIsoscelesTriangle.UseVisualStyleBackColor = false;
            this.btnIsoscelesTriangle.Click += new System.EventHandler(this.btnIsoscelesTriangle_Click);
            // 
            // btnRightTriangle
            // 
            this.btnRightTriangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRightTriangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender;
            this.btnRightTriangle.Image = global::Simple_Paint.Properties.Resources.right_triangle1;
            this.btnRightTriangle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRightTriangle.Location = new System.Drawing.Point(11, 284);
            this.btnRightTriangle.Name = "btnRightTriangle";
            this.btnRightTriangle.Size = new System.Drawing.Size(43, 43);
            this.btnRightTriangle.TabIndex = 18;
            this.btnRightTriangle.UseVisualStyleBackColor = false;
            this.btnRightTriangle.Click += new System.EventHandler(this.btnRightTriangle_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Images (BMP, PNG, JPG)|*.bmp; *.png; *.jpg";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|PNG image (*.png)|*.png|JPEG image (*.jpg)|*.jpg";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(75, 32);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1071, 584);
            this.panel.TabIndex = 19;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 616);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnRightTriangle);
            this.Controls.Add(this.btnIsoscelesTriangle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.penSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFillColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnFillColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1164, 663);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1164, 663);
            this.Name = "MainWindow";
            this.Text = "Simple Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown penSize;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnIsoscelesTriangle;
        private System.Windows.Forms.Button btnRightTriangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel;
    }
}

