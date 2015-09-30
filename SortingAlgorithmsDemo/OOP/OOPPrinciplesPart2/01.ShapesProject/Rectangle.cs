namespace _01.ShapesProject
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        protected override double CalculteSurface()
        {
            return Height*Width;
        }
    }
}
