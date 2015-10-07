using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    public abstract class PersonalComputer:Computer
    {
        protected PersonalComputer(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage)
            : base(cpu, ram, gpu, storage)
        {
        }

        public abstract void Play(int playNumber);
        public abstract void ChargeBattery(int powerPercentage);
    }
}
