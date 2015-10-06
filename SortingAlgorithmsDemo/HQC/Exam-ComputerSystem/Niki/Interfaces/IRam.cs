namespace Computers.UI.Console.Interfaces
{
    interface IRam
    {
        int Amount { get; set; }

        void SaveValue(int number);

        int LoadValue();
    }
}
