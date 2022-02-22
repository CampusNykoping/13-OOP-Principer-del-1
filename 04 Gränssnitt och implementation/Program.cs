using System;

namespace _04_Gränssnitt_och_implementation
{
    public interface IShape
    {
        void SetPosition(int x, int y);
        int CalculateSurface();
    }
    public interface IMovable
    {
        void Move(int deltaX, int deltaY);
    }
    public interface IResizable
    {
        void Resize(int weight);
        void Resize(int weightX, int weightY);
        void ResizeByX(int weightX);
        void ResizeByY(int weightY);
    }

    class Rectangle : IShape, IMovable
    {
        protected int x, y, width, height;
        public Rectangle()
        {

        }
        public Rectangle(int w, int h)
        {
            if (w == h)
            {
                throw new ArgumentOutOfRangeException("Width must be != height");
            }
            this.width = w;
            this.height = h;
        }
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CalculateSurface()
        {
            return this.width * this.height;
        }

        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }
    }

    class Square : Rectangle, IResizable
    {
        public Square(int size) : base(size, size)
        {
        }

        public void Resize(int weight)
        {
            throw new NotImplementedException();
        }

        public void Resize(int weightX, int weightY)
        {
            throw new NotImplementedException();
        }

        public void ResizeByX(int weightX)
        {
            throw new NotImplementedException();
        }

        public void ResizeByY(int weightY)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var rect1 = new Rectangle();
            rect1.SetPosition(2, 4);
            int area = rect1.CalculateSurface();

            var circle1 = new Circle();
            area = circle1.CalculateSurface();

            var square = new Square(2);

            rect1.Move(-1, -1);

        }
    }

    class Circle : IShape
    {
        private int x, y, radius;
        public Circle()
        {
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CalculateSurface()
        {
            return (int)Math.PI * radius * radius;
        }
    }
}
