using System;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class Ram:IRam
    {
        public Ram(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public void SaveValue(int value)
        {
            Amount = value;
        }

        public int LoadValue()
        {
            return Amount;
        }
    }
}
