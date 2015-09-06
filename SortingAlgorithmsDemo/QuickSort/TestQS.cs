using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace QuickSort
{
    public class TestQs
    {
        static IList<int> Sort(IList<int> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            IList<int> less = new List<int>();
            IList<int> greater = new List<int>();

            var rnd = new Random();

            var pivotPos = rnd.Next(input.Count);
            var pivot = input[pivotPos];

            input.RemoveAt(pivotPos);

            foreach (var i in input)
            {
                if (i < pivot)
                {
                    less.Add(i);
                }
                else
                {
                    greater.Add(i);
                }
            }

            less = Sort(less);
            greater = Sort(greater);

            return Concat(less,pivot, greater);
        }

        private static IList<int> Concat(IEnumerable<int> less, int pivot, IList<int> greater)
        {
            var result = new List<int>(less) {pivot};

            result.AddRange(greater);

            return result;
        } 
    }
}
