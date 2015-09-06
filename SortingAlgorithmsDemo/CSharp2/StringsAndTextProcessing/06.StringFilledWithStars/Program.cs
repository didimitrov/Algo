/* Write a program that reads from the console a 
 * string of maximum 20 characters. If the length of 
 * the string is less than 20, the rest of the 
 * characters should be filled with '*'. 
 * Print the result string into the console.
 */

using System;

namespace _06.StringFilledWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxSymbols = 20;

            string input = Console.ReadLine();

            if (input.Length < maxSymbols)
            {
                Console.WriteLine(input.PadRight(maxSymbols, '*'));
            }

        }
    }
}
