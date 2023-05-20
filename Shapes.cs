namespace OOP_LR6
{
    internal interface ICloneable
    {
        ICloneable clone();
    }

    internal interface IDrawable
    {
        void draw();
    }

    internal interface IMoveable
    {
        void moveLeft();
        void moveRight();
        void moveDown();
        void moveUp();
    }

    internal interface IResizeable
    {
        void resize(in bool isIncrease);
        void setSize(int _x, int _y, int _width, int _height);
    }

    internal abstract class Shape : ICloneable, IDrawable, IMoveable, IResizeable
    {
        public static PictureBox Box;
        public static Graphics g;
        protected int x, y, height = 10, width = 10;
        protected Color color;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public Color Color
        {
            set
            {
                this.color = value;
            }
        }
        public virtual ICloneable clone() { return null; }
        public virtual void draw() { }
        public virtual Shape getRealObj()
        {
            return this;
        }
        public void moveLeft() 
        {
            x -= 25;
            if (isOut())
            {
                x = width / 2;
            }
        }
        public void moveRight() 
        {
            x += 25;
            if (isOut())
            {
                x = (int)(Box.Size.Width - width / 2);
            }
        }
        public void moveDown()
        {
            y += 25;
            if (isOut())
            {
                y = (int)(Box.Size.Height - height / 2);
            }
        }
        public void moveUp()
        {

            y -= 25;
            if (isOut())
            {
                y = height / 2;
            }
        }
        public void resize(in bool isIncrease)
        {
            int _width = width, _height = height;
            if (isIncrease == true)
            {
                width = _width + 25;
                height = _height + 25 * _height / _width;
            }
            else
            {
                width = _width - 25;
                height = _height - 25 * _height / _width;
            }
            if (isOut() || width < 10 || height < 10)
            {
                width = _width;
                height = _height;
            }
        }
        public virtual void setSize(int _x, int _y, int _width, int _height)
        {
            x = _x + _width / 2;
            y = _y + _height / 2;
            height = _height > 0 ? _height : -_height;
            height = height < 10 ? 10 : height;
            width = _width > 0 ? _width : -_width;
            width = width < 10 ? 10 : width;
            if (x > Box.Size.Width - width / 2)
            {
                width = Box.Size.Width - _x;
                x = _x + width / 2;
            }
            if (y > Box.Size.Height - height / 2)
            {
                height = Box.Size.Height - _y;
                y = _y + height / 2;
            }
        }
        public void procKey(in Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    moveLeft();
                    break;
                case Keys.Right:
                    moveRight();
                    break;
                case Keys.Down:
                    moveDown();
                    break;
                case Keys.Up:
                    moveUp();
                    break;
                case Keys.Add:
                    resize(true);
                    break;
                case Keys.Subtract:
                    resize(false);
                    break;
            }
        }
        public bool isOut()
        {
            return !(x >= width / 2
            && x <= Box.Size.Width -  width / 2
            && y <= Box.Size.Height - height / 2 
            && y >= height / 2);
        }
        public virtual bool isPosses(int x, int y)
        {
            return false;
        }
        public virtual bool isSelected()
        {
            return false;
        }
    }
    internal class Rectangle : Shape
    {
        public override ICloneable clone()
        {
            return new Rectangle();
        }
        public override void draw()
        {
            g.FillRectangle(new SolidBrush(color), x - width / 2, y - height / 2, width, height);
        }
        public override bool isPosses(int _x, int _y)
        {
            return _x >= x - width / 2
                && _x <= x + width / 2
                && _y >= y - height / 2
                && _y <= y + height / 2;
        }
    }
    internal class Square : Rectangle
    {
        public override ICloneable clone()
        {
            return new Square();
        }
        public override void setSize(int _x, int _y, int _width, int _height)
        {
            if (_width > 0 && _height > 0)
            {
                _width = _width > _height ? _width : _height;
                _height = _width;
            }
            else if (_width > 0 && _height < 0)
            {
                _width = _width > -_height ? _width : -_height;
                _height = -_width;
            } 
            else if (_width < 0 && _height > 0)
            {
                _width = -_width > _height ? _width : -_height;
                _height = -_width;
            }
            else
            {
                _width = -_width > -_height ? _width : _height;
                _height = _width;
            }
            base.setSize(_x, _y, _width, _height);
        }
    }
    internal class Ellipse : Shape
    {
        public override ICloneable clone()
        {
            return new Ellipse();
        }
        public override void draw()
        {
            g.FillEllipse(new SolidBrush(color), x - width / 2, y - height / 2, width, height);
        }
        public override bool isPosses(int _x, int _y)
        {
            long dx = _x - x, dy = _y - y;
            long rx = width / 2, ry = height / 2;
            long tmp = dx * dx * ry * ry + dy * dy * rx * rx - rx * rx * ry * ry;
            return tmp <= 0;
        }
    }
    internal class Circle : Ellipse
    {
        public override ICloneable clone()
        {
            return new Circle();
        }
        public override void setSize(int _x, int _y, int _width, int _height)
        {
            if (_width > 0 && _height > 0)
            {
                _width = _width > _height ? _width : _height;
                _height = _width;
            }
            else if (_width > 0 && _height < 0)
            {
                _width = _width > -_height ? _width : -_height;
                _height = -_width;
            }
            else if (_width < 0 && _height > 0)
            {
                _width = -_width > _height ? _width : -_height;
                _height = -_width;
            }
            else
            {
                _width = -_width > -_height ? _width : _height;
                _height = _width;
            }
            base.setSize(_x, _y, _width, _height);
        }
    }
    internal class Section : Shape
    {
        //0 - 1st quarter
        //1 - 2nd _
        //2 - 3rd _
        //3 - 4th _
        int direction;
        public override ICloneable clone()
        {
            return new Section();
        }
        public override void draw()
        {
            switch (direction)
            {
                case 0:
                    g.DrawLine(new Pen(color), x - width / 2, y - height / 2, x + width / 2, y + height / 2);
                    break;
                case 1:
                    g.DrawLine(new Pen(color), x + width / 2, y - height / 2, x - width / 2, y + height / 2);
                    break;
                case 2:
                    g.DrawLine(new Pen(color), x + width / 2, y + height / 2, x - width / 2, y - height / 2);
                    break;
                case 3:
                    g.DrawLine(new Pen(color), x - width / 2, y + height / 2, x + width / 2, y - height / 2);
                    break;
            }
        }
        public override bool isPosses(int _x, int _y)
        {
            return _x >= x - width / 2
                && _x <= x + width / 2
                && _y >= y - height / 2
                && _y <= y + height / 2;
        }
        public override void setSize(int _x, int _y, int _width, int _height)
        {
            if (_width > 0 && _height > 0)
            {
                direction = 0;
            }
            else if (_width < 0 && _height > 0)
            {
                direction = 1;
            }
            else if (_width < 0 && _height < 0)
            {
                direction = 2;
            }
            else
            {
                direction = 3;
            }
            base.setSize(_x, _y, _width, _height);
        }
    }
    internal class Triangle : Shape
    {
        public override ICloneable clone()
        {
            return new Triangle();
        }
        public override void draw()
        {
            Point[] tmp_polygon = new Point[3];
            tmp_polygon[0] = new Point(x, y - height / 2);
            tmp_polygon[1] = new Point(x - width / 2, y + height / 2);
            tmp_polygon[2] = new Point(x + width / 2, y + height / 2);
            g.FillPolygon(new SolidBrush(color), tmp_polygon);
        }
        public override bool isPosses(int _x, int _y)
        {
            int p = vect(x - _x, y - height / 2 - _y, x - width / 2 - x, y + height / 2 - (y - height / 2)),
                q = vect(x - width / 2 - _x, y + height / 2 - _y, x + width / 2 - (x - width / 2), y + height / 2 - (y + height / 2)),
                r = vect(x + width / 2 - _x, y + height / 2 - _y, x - (x + width / 2), y - height / 2 - (y + height / 2));
            return ((p <= 0 && q <= 0 && r <= 0) || (p >= 0 && q >= 0 && r >= 0));
        }
        private int vect(int x1, int y1, int x2, int y2) 
        {
            return x1 * y2 - x2 * y1;
        }
    }

    internal class Decorator : Shape
    {
        protected Shape shape;
        public Decorator(Shape _shape)
        {
            shape = _shape;
        }
        public override void draw()
        {
            shape.draw();
            g.DrawRectangle(new Pen(Brushes.Firebrick, 2), shape.X - shape.Width / 2, shape.Y - shape.Height / 2, shape.Width, shape.Height);
        }
        public override Shape getRealObj()
        {
            return shape.getRealObj();
        }
        public override bool isSelected()
        {
            return true;
        }
    }
}