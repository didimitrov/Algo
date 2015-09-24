/*
 * 6. Write a program that removes from given 
 * sequence all numbers that occur odd number of times. 
- Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06.RemoveOddTimeNumbers
{
    public class ListUtils
    {
        private static Dictionary<int, int> CountNumbers(IList<int> sequance)
        {
            if (sequance == null || sequance.Count == 0)
            {
                throw new ArgumentNullException();
            }
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < sequance.Count; i++)
            {
                if (dict.ContainsKey(sequance[i]))
                {
                    dict[sequance[i]]++;
                }
                else
                {
                    dict.Add(sequance[i], 1);
                }
            }

            return dict;
        }

        public static List<int> RemoveOdd(List<int> seqence)
        {
            if (seqence == null || seqence.Count == 0)
            {
                throw new ArgumentNullException();
            }

           var numbersCount = CountNumbers(seqence);

            foreach (KeyValuePair<int, int> i in numbersCount)
            {
                if (i.Value % 2 != 0)
                {
                    seqence.RemoveAll(x => x == i.Key);
                }
            }

            return seqence;
        }
    }
}
