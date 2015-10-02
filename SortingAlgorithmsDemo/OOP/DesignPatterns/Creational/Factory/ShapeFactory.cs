namespace Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shape)
        {
            if (shape.ToLower()=="square")
            {
                return new Square();
            }
            if (shape.ToLower()=="rectangle")
            {
                return new Rectangle();
            }
            if (shape.ToLower()=="triangle")
            {
                return new Triangle();
            }

            return null;
        }
    }
}
