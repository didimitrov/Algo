

namespace Computers.UI.Console.Interfaces
{
    interface IBatery
    {
        int Percentage { get; set; }
        void Charge(int p);
    }
}
