using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    internal class Laptop : PersonalComputer, ILaptop
    {
        public Laptop(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage, IRechargable battery)
            : base(cpu, ram, gpu, storage)
        {
            Battery = battery;
        }


        public IRechargable Battery { get; private set; }

        public override void Play(int guessNumber)
        {
            throw new Exception("You cannot play games on your laptop.");
        }

        public override void ChargeBattery(int powerPercentage)
        {
            this.Battery.Charge(powerPercentage);

            this.Gpu.DrawTextData(string.Format("Battery status: {0}%", this.Battery.CurrentCharge));

        }
    }
}
