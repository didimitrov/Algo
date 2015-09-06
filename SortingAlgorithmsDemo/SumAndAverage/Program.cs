using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var numbers = new List<int>();

            if (!String.IsNullOrEmpty(input))
            {
                //numbers = input.Split(' ').ToList().ConvertAll(Convert.ToInt32);
                numbers = input.Split().Select(int.Parse).ToList();
            }
            else
            {
                numbers.Add(0);
            }

            Console.WriteLine("Sum is {0}", numbers.Sum());
            Console.WriteLine("Averege is {0}", numbers.Average());
        }
    }
}
