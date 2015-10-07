namespace Computers.UI.Console.Interfaces
{
   public interface IRechargable
    {
        int CurrentCharge { get; }
        void Charge(int powerInput);
    }
}
