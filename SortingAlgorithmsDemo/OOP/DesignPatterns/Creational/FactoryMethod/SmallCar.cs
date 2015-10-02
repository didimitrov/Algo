using System;

namespace FactoryMethod
{
    class SmallCar:Car
    {
        public SmallCar(CarType type) : base(CarType.Small)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Build Small car");
        }
    }
}
