using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SubseqenceofEvenNumbers
{
   public class ListUtils
    {
        public static List<int> FindLongestSubseqence(List<int> sequence)
        {
            if (sequence == null || sequence.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            var bestNumber = 0;
            var bestLength = 0;
            var currentLength = 1;
            var currentNumber = 0;

            for (int i = 0; i < sequence.Count-1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLength++;
                    currentNumber = sequence[i];
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestNumber = currentNumber;
                    }
                    currentLength = 1;
                }
            }
            List<int> subSeqence = Enumerable.Repeat(bestNumber, bestLength).ToList();
            return subSeqence;
        }

       public static void Print(IList<int> sequence)
        {
            foreach (int t in sequence)
            {
                Console.Write(t + " ");
            }
        }
    }
}
