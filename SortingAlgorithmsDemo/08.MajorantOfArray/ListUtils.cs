/*
 * 8. The majorant of an array of size N is a value that 
 * occurs in it at least N/2 + 1 times. 
 * Write a program to find the majorant of given array (if exists). 
- Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} ? 3
 */

using System;
using System.Collections.Generic;

namespace _08.MajorantOfArray
{
    public class ListUtils
    {
        public static int FindMajorant(IList<int> sequence)
        {
            if (sequence == null || sequence.Count == 0)
            {
                throw new ArgumentNullException("Sequance must not be empty!");
            }

            int bestMajorant = 0;

            var countedElements = NumberConter(sequence);

            foreach (var element in countedElements)
            {
                if (element.Value >= (sequence.Count / 2) - 1)
                {
                    if (bestMajorant < element.Value)
                    {
                        bestMajorant = element.Key;
                    }
                }
            }
            return bestMajorant;
        }

       private static Dictionary<int, int> NumberConter(ICollection<int> arr)
        {
            var dictionary = new Dictionary<int, int>();

            if (arr == null || arr.Count == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (int t in arr)
            {
                if (dictionary.ContainsKey(t))
                {
                    dictionary[t]++;
                }
                else
                {
                    dictionary.Add(t, 1);
                }
            }

            return dictionary;
        } 
    }
}
