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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
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
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnColor
            // 
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFillColor
            // 
            resources.ApplyResources(this.btnFillColor, "btnFillColor");
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // lblFillColor
            // 
            resources.ApplyResources(this.lblFillColor, "lblFillColor");
            this.lblFillColor.Name = "lblFillColor";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // penSize
            // 
            resources.ApplyResources(this.penSize, "penSize");
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
            this.penSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSize.ValueChanged += new System.EventHandler(this.penSize_ValueChanged);
            // 
            // btnDemo
            // 
            resources.ApplyResources(this.btnDemo, "btnDemo");
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            resources.ApplyResources(this.btnLine, "btnLine");
            this.btnLine.Name = "btnLine";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnEllipse
            // 
            resources.ApplyResources(this.btnEllipse, "btnEllipse");
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            resources.ApplyResources(this.btnCircle, "btnCircle");
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            resources.ApplyResources(this.btnRectangle, "btnRectangle");
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            resources.ApplyResources(this.btnSquare, "btnSquare");
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnIsoscelesTriangle
            // 
            resources.ApplyResources(this.btnIsoscelesTriangle, "btnIsoscelesTriangle");
            this.btnIsoscelesTriangle.Name = "btnIsoscelesTriangle";
            this.btnIsoscelesTriangle.UseVisualStyleBackColor = true;
            // 
            // btnRightTriangle
            // 
            resources.ApplyResources(this.btnRightTriangle, "btnRightTriangle");
            this.btnRightTriangle.Name = "btnRightTriangle";
            this.btnRightTriangle.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
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
    }
}

