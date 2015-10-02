namespace FactoryMethod
{
    class CarFactory
    {
        public Car GetCar(CarType type)
        {
            if (type == CarType.Luxury)
            {
                return new LuxuryCar(CarType.Luxury);
            }
            if (type==CarType.Sedan)
            {
                return new SedanCar(CarType.Sedan);
            }
            if (type==CarType.Small)
            {
                return new SmallCar(CarType.Small);
            }

            return null;

        }
    }
}
