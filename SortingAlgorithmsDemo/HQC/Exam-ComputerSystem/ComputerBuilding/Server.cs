
using Computers.UI.Console.Components;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class Server:Computer, IServer
    {
        public Server(ICpu cpu, IRam ram, IVideoCard gpu, IStorage storage) 
            : base(cpu, ram, new MonochromVideoCard(), storage)
        {
            
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            this.Cpu.SquareNumber();
        }
    }
}
