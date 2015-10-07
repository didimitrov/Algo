using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class MonochromVideoCard:IVideoCard
    {
        public void DrawTextData(string data)
        {
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine(data);
            System.Console.ResetColor();
           
        }
    }
}
