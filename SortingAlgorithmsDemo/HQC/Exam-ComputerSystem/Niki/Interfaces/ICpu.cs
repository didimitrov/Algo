namespace Computers.UI.Console.Interfaces
{
    interface ICpu
    {
        byte NumberOfCores { get; set; }
       
        void SquareNumber();

        void GenerateRandom(int a, int b);
    }
}
