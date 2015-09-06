using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        public static IList<int> Sort(IList<int> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            var midpoint = input.Count/2;

            IList<int> left = new List<int>();
            IList<int> right = new List<int>();

            for (var i = 0; i < midpoint; i++)
            {
                left.Add(input[i]);
            }

            for (var i = midpoint; i < input.Count; i++)
            {
                right.Add(input[i]);
            }

            left = Sort(left);
            right = Sort(right);
            
            return Merge(left, right);
        }

        public static IList<int> Merge(IList<int> left, IList<int> right)
        {
            IList<int> result = new List<int>();

            while (left.Any() && right.Any())
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }

            while (left.Any())
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Any())
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        } 



        static void Main()
        {
            var arr = new[] { 800, 11, 50, 771, 649, 770, 240, 9 };
            var sorted = Sort(arr);
            foreach (var i in sorted)
            {
                Console.Write(i + " ");
            }
           
        }
    }
}
