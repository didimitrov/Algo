using Computers.UI.Console.Factory;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    public class ComputerCreator
    {
        private readonly IComputerFactory computerFactory;

        public ComputerCreator(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }

        public IDesktop AssembleDesktop()
        {
            return this.computerFactory.CreateDesktop();
        }

        public IServer AssembleServer()
        {
            return this.computerFactory.CreateServer();
        }

        public ILaptop AssembleLaptop()
        {
            return this.computerFactory.CreateLaptop();
        }
    }
}
