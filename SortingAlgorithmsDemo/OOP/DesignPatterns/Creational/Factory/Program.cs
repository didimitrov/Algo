using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ShapeFactory();

           var square= factory.GetShape("square");

            square.Draw();
        }
    }
}
