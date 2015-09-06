/*
 * Write a program that reads from the console a sequence of N integer numbers 
 * and returns the minimal and maximal of them.
*/

using System;
using System.Linq;

namespace _03.FindMinAndMaxFromNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("n= ");
            //var n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Elemen[{0}]: ", i);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(numbers);


            var input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            var sorted = numbers.OrderBy(x => x).ToArray();

            Console.WriteLine("Min is: {0}, Max is: {1}", numbers[0], numbers[numbers.Length-1] );
        }
    }
}
