namespace Computers.UI.Console.Interfaces
{
    interface IRechargable
    {
        int CurrentCharge { get; }
        void Charge(int powerInput);
    }
}
