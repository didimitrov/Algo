/*
 * 03. Write a program that reads a sequence 
 * of integers (List<int>) ending with an empty line 
 * and sorts them in an increasing order.
 */

using System;
using System.Collections.Generic;

namespace _03.SortSequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                int inputNumber = int.Parse(input);
                numbers.Add(inputNumber);

                input = Console.ReadLine();
            }

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.Write(number+" ");
            }
        }
    }
}
