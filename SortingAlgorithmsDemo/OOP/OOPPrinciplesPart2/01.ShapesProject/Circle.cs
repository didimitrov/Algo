using System;

namespace _01.ShapesProject
{
    class Circle:Shape
    {
        public Circle(double diameter) : base(diameter, diameter)
        {
        }

        protected override double CalculteSurface()
        {
          return ((this.Width / 2.0) * (this.Width / 2.0) * Math.PI);
        }
    }
}
