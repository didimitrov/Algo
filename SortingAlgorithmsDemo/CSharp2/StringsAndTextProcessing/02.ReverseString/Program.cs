/* Write a program that reads a string, 
 * reverses it and prints the result at the console.
 * Example: "sample"  "elpmas".
 */

using System;

namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            var input = Console.ReadLine();

            for (int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

        }
    }
}
