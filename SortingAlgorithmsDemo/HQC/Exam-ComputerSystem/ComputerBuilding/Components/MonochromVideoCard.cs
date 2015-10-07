using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Components
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
