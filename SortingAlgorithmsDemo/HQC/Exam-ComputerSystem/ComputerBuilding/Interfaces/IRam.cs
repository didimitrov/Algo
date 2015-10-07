namespace Computers.UI.Console.Interfaces
{
    public interface IRam
    {
        int Amount { get; set; }

        void SaveValue(int number);

        int LoadValue();
    }
}
