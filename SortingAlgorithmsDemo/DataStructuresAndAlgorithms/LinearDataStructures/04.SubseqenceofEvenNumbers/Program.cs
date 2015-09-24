/*
 * 4. Write a method that finds the longest 
 * subsequence of equal numbers in given List<int> and 
 * returns the result as new List<int>. 
 * Write a program to test whether the method works correctly.
 */

using System.Collections.Generic;

namespace _04.SubseqenceofEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sequence = new List<int>() { 1, 2, 6, 3, 4, 2, 2, 2, 2, 2, 33, 1, 1 };

            var sorted = ListUtils.FindLongestSubseqence(sequence);

            ListUtils.Print(sorted);
        }
    }
}
