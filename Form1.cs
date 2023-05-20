namespace OOP_LR6
{
    public partial class mainForm : Form
    {
        MyContainer<Shape> container = new MyContainer<Shape>(100);
        Color actualColor;
        Shape actualShape;
        bool isCreatingShape,
            isCtrl;
        int x_begin, y_begin;

        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            Shape.Box = pictureBox;
            actualColor = blackToolStripMenuItem.ForeColor;
            blackToolStripMenuItem.Checked = true;
            actualShape = rectangleToolStripMenuItem.Tag as Shape;
            rectangleToolStripMenuItem.Checked = true;
            isCreatingShape = false;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Shape.g = e.Graphics;
            for (int i = 0; i < container.Count; i++)
            {
                container[i].draw();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = sender as ToolStripMenuItem;
            actualColor = obj.ForeColor;
            skyBlueToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = false;
            obj.Checked = true;
        }
        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = sender as ToolStripMenuItem;
            actualShape = obj.Tag as Shape;
            squareToolStripMenuItem.Checked = false;
            circleToolStripMenuItem.Checked = false;
            ellipseToolStripMenuItem.Checked = false;
            sectionToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            obj.Checked = true;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isCreatingShape)
            {
                isCreatingShape = true;
                for (int i = 0; i < container.Count; i++)
                {
                    container[i] = container[i].getRealObj();
                }
                Shape tmp = new Decorator(actualShape.clone() as Shape);
                x_begin = e.X;
                y_begin = e.Y;
                tmp.getRealObj().setSize(x_begin, y_begin, 0, 0);
                tmp.getRealObj().Color = actualColor;
                container.Add(tmp);
                pictureBox.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (container.Count == 0)
                {
                    return;
                }
                if (isCtrl == false)
                {
                    for (int i = 0; i < container.Count; i++)
                    {
                        container[i] = container[i].getRealObj();
                    }
                }
                bool isSelectSomething = isCtrl;
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].getRealObj().isPosses(e.X, e.Y) && !container[i].isSelected())
                    {
                        container[i] = new Decorator(container[i]);
                        isSelectSomething = true;
                        break;
                    }
                }
                if (!isSelectSomething)
                {
                    container[container.Count - 1] = new Decorator(container[container.Count - 1]);
                }
                pictureBox.Invalidate();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    container[i] = container[i].getRealObj();
                }
                pictureBox.Invalidate();
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isCreatingShape = false;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCreatingShape)
            {
                container[container.Count - 1].getRealObj().setSize(x_begin, y_begin, e.X - x_begin, e.Y - y_begin);
                pictureBox.Invalidate();
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrl = true;
                return;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected())
                    {
                        container.remove(i);
                        i--;
                    }
                }
                if (container.Count > 0)
                {
                    container[container.Count - 1] = new Decorator(container[container.Count - 1]);
                }
            }
            else
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected())
                    {
                        container[i].getRealObj().procKey(e.KeyCode);
                    }
                }
            }
            pictureBox.Invalidate();
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrl = false;
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isSelected())
                {
                    container[i].getRealObj().Color = actualColor;
                }
            }
            pictureBox.Invalidate();
        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].getRealObj().isOut())
                {
                    int new_X = container[i].getRealObj().X + container[i].getRealObj().Width / 2 + 18,
                        new_Y = container[i].getRealObj().Y + container[i].getRealObj().Height / 2 + 75;
                    if (new_X < Size.Width)
                    {
                        new_X = Size.Width;
                    }
                    if (new_Y < Size.Height)
                    {
                        new_Y = Size.Height;
                    }
                    Size = new Size(new_X, new_Y);
                    return;
                }
            }
        }
    }
}