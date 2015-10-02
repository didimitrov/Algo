using System;

namespace Factory
{
   public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw()");
        }
    }

    public class Triangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Triangle Draw()");
        }
    }

    public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is Square Draw()");
        }
    }
}
