namespace Computers.UI.Console.Interfaces
{
    interface IComputer
    {
        ICpu Cpu { get; }

        IRam Ram { get; }

        IVideoCard Gpu { get; }

        IStorage Storage { get; }
    }
}
