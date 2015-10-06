

using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class Computer:IComputer
    {
        public Computer(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage)
        {
            Storage = storage;
            Gpu = gpu;
            Ram = ram;
            Cpu = cpu;
        }

        public ICpu Cpu { get; private set; }
        public IRam Ram { get; private set; }
        public IVideoCard Gpu { get; private set; }
        public IStorage Storage { get; private set; }
    }
}
