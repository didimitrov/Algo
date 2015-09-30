namespace _01.ShapesProject
{
    public abstract class Shape
    {
        protected Shape(double width, double height)
        {
            Height = height;
            Width = width;
        }

        public double Width { get; private set; }
        public double Height { get;private set; }

        protected abstract double CalculteSurface();
    }
}
