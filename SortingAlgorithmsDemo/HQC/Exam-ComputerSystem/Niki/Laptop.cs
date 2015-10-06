using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class Laptop: PersonalComputer,ILaptop
    {
        public Laptop(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage) : base(cpu, ram, gpu, storage)
        {
        }

        
        public IRechargable Battery
        {
            get;
            private set;
        }

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
