//10. Напишете програма, която намира най-често срещания елемент в
//масив. Пример: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (среща се 5
//пъти).

using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

            var dict = new Dictionary<int, int>();

            foreach (var i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, 1);
                }
            }

            var keyValue = dict.OrderByDescending(x => x.Value).First();

            Console.WriteLine("Frequent element: {0}", keyValue.Key);
            Console.WriteLine("Times: {0}", keyValue.Value);
        }
    }
}
