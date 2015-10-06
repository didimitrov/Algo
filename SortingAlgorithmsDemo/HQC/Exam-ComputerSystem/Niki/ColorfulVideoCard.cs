using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class ColorfulVideoCard:IVideoCard
    {
        public void DrawTextData(string data)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(data);
            System.Console.ResetColor();
        }
    }
}
