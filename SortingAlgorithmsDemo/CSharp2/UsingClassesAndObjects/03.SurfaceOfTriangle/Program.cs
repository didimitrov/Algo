/*
 * Write methods that calculate the surface of a triangle by given:
	 * Side and an altitude to it;
	 * Three sides;
	 * Two sides and an angle between them.
 */

using System;

namespace _03.SurfaceOfTriangle
{
    class Program
    {
        public static void SurfaceBySideAndAltitude()
        {
            Console.WriteLine("Enter side: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter altitude: ");
            double h = double.Parse(Console.ReadLine());

            if (a <= 0 || h <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var area = (a*h)/2;

            Console.WriteLine("Area is {0}", area);
        }

        static void Main(string[] args)
        {
        }
    }
}
