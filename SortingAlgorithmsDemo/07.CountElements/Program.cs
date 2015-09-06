/*
 * 7. Write a program that finds in given array of integers 
 * (all belonging to the range [0..1000]) how many times each of them occurs.
- Example: 
- array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
- 2 - 2 times
- 3 - 4 times
- 4 - 3 times
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountElements
{
    class Program
    {
        static Dictionary<int, int> NumberCount(int[] arr)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 || arr[i] > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else
                {
                    dictionary.Add(arr[i], 1);
                }
            }

            return dictionary;
        }

        static void Print(IEnumerable<KeyValuePair<int, int>> dictionary)
        {
            foreach (KeyValuePair<int, int> keyValuePair in dictionary)
            {
                Console.WriteLine("{0}-{1}", keyValuePair.Key, keyValuePair.Value);
            }
        }

        static void Main(string[] args)
        {
            var arr = new int[] {3, 4, 4, 2, 3, 3, 4, 3, 2};

            Print(NumberCount(arr).OrderBy(x=>x.Key));
        }
    }
}
