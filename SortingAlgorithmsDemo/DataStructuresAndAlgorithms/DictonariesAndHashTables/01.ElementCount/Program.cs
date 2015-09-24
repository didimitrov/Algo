/*
     * Write a program that finds in given array of integers 
     * (all belonging to the range [0..1000]) how many times each of them occurs.
     * 
     * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
     * 2  2 times
     * 3  4 times
     * 4  3 times
     */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ElementCount
{
    class Program
    {
        static void Print(Dictionary<int, int> sequance)
        {
            foreach (var source in sequance.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1}", source.Key, source.Value);
            }
        }

        static Dictionary<int, int> CountElements(int[] input)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]]++;
                }
                else
                {
                    dictionary.Add(input[i], 1);
                }
            }
            return dictionary;
        }

        static void Main(string[] args)
        {
        }
    }
}
