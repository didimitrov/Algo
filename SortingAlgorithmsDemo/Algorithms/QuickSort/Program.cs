using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        public static IList<int> Sort(IList<int> input)
        {
            var rnd = new Random();

            IList<int> less = new List<int>();
            IList<int> greater = new List<int>();

            if (input.Count <= 1)
            {
                return input;
            }

            var pos = rnd.Next(input.Count);
            var pivot = input[pos];

            input.RemoveAt(pos);

            foreach (var i in input)
            {
                if (i <= pivot)
                {
                    less.Add(i);
                }
                else
                {
                    greater.Add(i);
                }
            }

            //less = Sort(less);
            //greater = Sort(greater);
            //return Concat(less, pivot, greater);
            return Concat(Sort(less), pivot, Sort(greater));
        }

        private static IList<int> Concat(IEnumerable<int> less, int pivot, IList<int> greater)
        {
            var result = new List<int>(less);

            result.Add(pivot);

            foreach (var i in greater)
            {
                result.Add(i);
            }
            return result;

        }

        static void Main()
        {
            var unsortedList = new List<int> { 800, 11, 50, 771, 649, 770, 240, 9 };
            var sorted = Sort(unsortedList);
            foreach (var i in sorted)
            {
                Console.Write(i+" ");
            }
        }
    }
}
