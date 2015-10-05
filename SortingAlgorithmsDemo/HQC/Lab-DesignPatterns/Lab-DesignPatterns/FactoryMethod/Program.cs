using FactoryMethod;

namespace TankManufacturer
{
    using System;

    using TankManufacturer.Units;

    class Program
    {
        static void Main()
        {
            var faktory = new GermanFactory();
            var tank = faktory.CreateTank();

            //var tiger = new Tank("Tiger", 4.5, 120);
            //var t34 = new Tank("T 34", 3.3, 75);
            //var m1Abrams = new Tank("M1 Abrams", 5.4, 120);

            Console.WriteLine(tank);
        }
    }
}
