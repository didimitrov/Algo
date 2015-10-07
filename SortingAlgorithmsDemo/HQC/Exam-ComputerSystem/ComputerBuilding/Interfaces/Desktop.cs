namespace Computers.UI.Console.Interfaces
{
    public class Desktop : PersonalComputer, IDesktop
    {
        public Desktop(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage)
            : base(cpu, ram, gpu, storage)
        {
        }

        public override void Play(int guessNumber)
        {
            this.Cpu.GenerateRandom(1, 10);
            var number = this.Ram.LoadValue();

            if (number + 1 != guessNumber + 1)
            {
                this.Gpu.DrawTextData(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.Gpu.DrawTextData("You win!");
            }
        }

        public override void ChargeBattery(int powerPercentage)
        {
            System.Console.WriteLine("The desktop doesn't have a battery.");
        }
    }
}
