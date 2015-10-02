using System;

namespace FactoryMethod
{
    class SedanCar:Car
    {
        public SedanCar(CarType type) : base(CarType.Sedan)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Build Sedan car");
        }
    }
}
