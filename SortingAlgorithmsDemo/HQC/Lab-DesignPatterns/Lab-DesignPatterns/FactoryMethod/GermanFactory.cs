using TankManufacturer.Units;

namespace FactoryMethod
{
    class GermanFactory:ITankFactory
    {
        public Tank CreateTank()
        {
            var tank = new Tank("Tiger", 4.5, 120);
            return tank;
        }
    }
}
