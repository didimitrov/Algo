/*
 * 1. Write a program that reads from the console a sequence 
 * of positive integer numbers. The sequence ends when empty 
 * line is entered. Calculate and print the sum and average 
 * of the elements of the sequence. Keep the sequence in List<int>.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FindSumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequance = new List<int>();
            var input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                int number = int.Parse(input);
                sequance.Add(number);

                input = Console.ReadLine();
            }

            var sum = sequance.Sum();
            var avarage = sequance.Average();
        }
    }
}
