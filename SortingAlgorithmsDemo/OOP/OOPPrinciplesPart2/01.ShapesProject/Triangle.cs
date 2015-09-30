using System.Globalization;

namespace _01.ShapesProject
{
    class Triangle:Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        protected override double CalculteSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
