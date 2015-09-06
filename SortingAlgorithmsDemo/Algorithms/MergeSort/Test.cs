using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MergeSort
{
    public class Test
    {
        static IList<int> Sort(IList<int> input)
        {
            if (input.Count<=1)
            {
                return input;
            }

            var midPoint = input.Count/2;

            IList<int> left = new List<int>();
            IList<int> right = new List<int>();

            for (int i = 0; i < midPoint; i++)
            {
                left.Add(input[i]);
            }

            for (int i = midPoint; i < input.Count; i++)
            {
                right.Add(input[i]);
            }

            return Merge(Sort(left), Sort(right));

        }

        private static IList<int> Merge(IList<int> left, IList<int> right)
        {
            var result = new List<int>();

            while (left.Any() && right.Any())
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                result.Add(right[0]);
                right.Remove(right[0]);
            }

            while (left.Any())
            {
                result.Add(left[0]);
                left.Remove(left[0]);
            }
            while (right.Any())
            {
                result.Add(right[0]);
                right.Remove(right[0]);
            }


            return result;
        }

        
    }
}

