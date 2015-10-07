namespace Computers.UI.Console.Interfaces
{
    public interface ICpu
    {
        byte NumberOfCores { get; set; }
       
        void SquareNumber();

        void GenerateRandom(int a, int b);
    }
}
