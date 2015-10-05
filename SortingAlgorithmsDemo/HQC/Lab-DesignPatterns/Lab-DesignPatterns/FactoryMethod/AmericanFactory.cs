using TankManufacturer.Units;

namespace FactoryMethod
{
    class AmericanFactory:ITankFactory
    {
        public Tank CreateTank()
        {
            var tank = new Tank("M1 Abrams", 5.4, 120);
            return tank;
        }
    }
}
