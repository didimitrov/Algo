/*
 * Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
 */
using System;

namespace _01.IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            var input = Console.ReadLine();
            var data = Convert.ToDateTime(input);

            bool isLeap = DateTime.IsLeapYear(data.Year);
            Console.WriteLine("Is the year a leap: {0}", isLeap);

            //if (data.Year % 4==0)
            //{
            //    Console.WriteLine("Is leap");
            //}
            //Console.WriteLine("Its not leap.");
        }
    }
}
