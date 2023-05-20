namespace OOP_LR6
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Square square2 = new Square();
            Circle circle2 = new Circle();
            Ellipse ellipse2 = new Ellipse();
            Section section2 = new Section();
            Rectangle rectangle2 = new Rectangle();
            Triangle triangle2 = new Triangle();
            menuStrip = new MenuStrip();
            shapesToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            sectionToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            skyBlueToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            orangeToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            pictureBox = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { shapesToolStripMenuItem, colorToolStripMenuItem, changeColorToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(882, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            shapesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { squareToolStripMenuItem, circleToolStripMenuItem, ellipseToolStripMenuItem, sectionToolStripMenuItem, rectangleToolStripMenuItem, triangleToolStripMenuItem });
            shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            shapesToolStripMenuItem.Size = new Size(76, 24);
            shapesToolStripMenuItem.Text = "Фигуры";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(203, 26);
            squareToolStripMenuItem.Tag = square2;
            squareToolStripMenuItem.Text = "Квадрат";
            squareToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(203, 26);
            circleToolStripMenuItem.Tag = circle2;
            circleToolStripMenuItem.Text = "Круг";
            circleToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(203, 26);
            ellipseToolStripMenuItem.Tag = ellipse2;
            ellipseToolStripMenuItem.Text = "Овал";
            ellipseToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // sectionToolStripMenuItem
            // 
            sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            sectionToolStripMenuItem.Size = new Size(203, 26);
            sectionToolStripMenuItem.Tag = section2;
            sectionToolStripMenuItem.Text = "Отрезок";
            sectionToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(203, 26);
            rectangleToolStripMenuItem.Tag = rectangle2;
            rectangleToolStripMenuItem.Text = "Прямоугольник";
            rectangleToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(203, 26);
            triangleToolStripMenuItem.Tag = triangle2;
            triangleToolStripMenuItem.Text = "Треугольник";
            triangleToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { skyBlueToolStripMenuItem, yellowToolStripMenuItem, greenToolStripMenuItem, redToolStripMenuItem, orangeToolStripMenuItem, blueToolStripMenuItem, purpleToolStripMenuItem, blackToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(56, 24);
            colorToolStripMenuItem.Text = "Цвет";
            // 
            // skyBlueToolStripMenuItem
            // 
            skyBlueToolStripMenuItem.ForeColor = Color.SkyBlue;
            skyBlueToolStripMenuItem.Name = "skyBlueToolStripMenuItem";
            skyBlueToolStripMenuItem.Size = new Size(180, 26);
            skyBlueToolStripMenuItem.Text = "Голубой";
            skyBlueToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.ForeColor = Color.Yellow;
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(180, 26);
            yellowToolStripMenuItem.Text = "Желтый";
            yellowToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.ForeColor = Color.Green;
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(180, 26);
            greenToolStripMenuItem.Text = "Зеленый";
            greenToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.ForeColor = Color.Red;
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(180, 26);
            redToolStripMenuItem.Text = "Красный";
            redToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // orangeToolStripMenuItem
            // 
            orangeToolStripMenuItem.BackColor = SystemColors.Control;
            orangeToolStripMenuItem.ForeColor = Color.Orange;
            orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            orangeToolStripMenuItem.Size = new Size(180, 26);
            orangeToolStripMenuItem.Text = "Оранжевый";
            orangeToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.BackColor = SystemColors.Control;
            blueToolStripMenuItem.ForeColor = Color.Blue;
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(180, 26);
            blueToolStripMenuItem.Text = "Синий";
            blueToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.BackColor = SystemColors.Control;
            purpleToolStripMenuItem.ForeColor = Color.Purple;
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(180, 26);
            purpleToolStripMenuItem.Text = "Фиолетовый";
            purpleToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.BackColor = SystemColors.Control;
            blackToolStripMenuItem.ForeColor = Color.Black;
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(180, 26);
            blackToolStripMenuItem.Text = "Черный";
            blackToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(127, 24);
            changeColorToolStripMenuItem.Text = "Изменить цвет";
            changeColorToolStripMenuItem.Click += changeColorToolStripMenuItem_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 28);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(882, 425);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Paint += panel_Paint;
            pictureBox.MouseDown += panel_MouseDown;
            pictureBox.MouseMove += panel_MouseMove;
            pictureBox.MouseUp += panel_MouseUp;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "mainForm";
            Text = "Paint";
            Load += mainForm_Load;
            SizeChanged += mainForm_SizeChanged;
            KeyDown += mainForm_KeyDown;
            KeyUp += mainForm_KeyUp;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem sectionToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem skyBlueToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem orangeToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private PictureBox pictureBox;
        private ToolStripMenuItem changeColorToolStripMenuItem;
    }
}