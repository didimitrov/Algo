using System;

namespace FactoryMethod
{
    class LuxuryCar:Car
    {
        public LuxuryCar(CarType type) : base(CarType.Luxury)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Build luxury car");
            // add accessories
        }
    }
}
