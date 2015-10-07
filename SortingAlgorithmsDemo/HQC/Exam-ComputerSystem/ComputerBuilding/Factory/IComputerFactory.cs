using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Factory
{
    public interface IComputerFactory
    {
        IDesktop CreateDesktop();
        ILaptop CreateLaptop();
        IServer CreateServer();
    }
}
