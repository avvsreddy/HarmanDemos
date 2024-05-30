namespace InterviewQDesicussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //s.Draw();
            //Rectangle rectangle = new Rectangle();
            //rectangle.Draw();

            //Shape s = new Rectangle();
            //s.Draw();
            //s = new Triangle();
            //s.Draw();
            //DrawShape(new Rectangle());
            DrawShape(new Triangle());


        }

        static void DrawShape(Shape s)
        {
            s.Draw();
        }
    }


    class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    interface IShape
    {
        void Draw();
    }

    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class Triangle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
}
