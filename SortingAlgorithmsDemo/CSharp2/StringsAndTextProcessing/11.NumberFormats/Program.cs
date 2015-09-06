/*
* 11. Write a program that reads a number and prints it as a decimal
* number, hexadecimal number, percentage and in scientific notation.
* Format the output aligned right in 15 symbols.
*/

using System;
using System.Linq;

namespace _11.NumberFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);

            Console.WriteLine("Decimal - {0, 15}", number);
            Console.WriteLine("Hexadecimal - {0, 15:X}", number);
            Console.WriteLine("Percentage - {0, 15:P}", number);
            Console.WriteLine("{0,15:E} - Scientific format\n", number);
        }
    }
}
