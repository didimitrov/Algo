using TankManufacturer.Units;

namespace FactoryMethod
{
    class RussianFactory:ITankFactory
    {
        public Tank CreateTank()
        {
            var tank = new Tank("T 34", 3.3, 75);
            return tank;
        }
    }
}
