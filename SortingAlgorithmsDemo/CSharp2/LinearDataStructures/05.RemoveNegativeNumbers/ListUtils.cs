

using System;
using System.Collections.Generic;
using System.Text;

namespace _05.RemoveNegativeNumbers
{
    public class ListUtils
    {
        public static List<int> RemoveNegativeNums(List<int> sequence)
        {
            if (sequence == null || sequence.Count <= 1)
            {
                throw  new ArgumentNullException();
            }

            var negativeNums = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] < 0)
                {
                    negativeNums.Add(sequence[i]);
                }
            }

            foreach (int t in negativeNums)
            {
                sequence.Remove(t);
            }

            return sequence;
        }

        public static void Print(IList<int> sequence)
        {
            if (sequence == null || sequence.Count <= 1)
            {
                throw new ArgumentNullException();
            }

            var sb = new StringBuilder();

            for (int i = 0; i < sequence.Count; i++)
            {
                sb.AppendFormat("{0} ", sequence[i]);
            }

            Console.WriteLine(sb.ToString().Trim(' ', ','));
        }
    }
}
