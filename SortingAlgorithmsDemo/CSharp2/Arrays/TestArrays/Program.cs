/* Write a program that finds the sequence of maximal sum in given array. Example:
{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
Can you do it with only one loop (with single scan through the elements of the array)?
 */


using System;
using System.Text;
using System.Windows.Markup;

namespace TestArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};

            var bestSum = 0;
            var currentSum = 0;
            var sb = new StringBuilder();
            var bestSequance = "";

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                currentSum = currentSum + arr[i];

                if (currentSum > bestSum)
                { 
                    bestSequance = sb.ToString();
                    bestSum = currentSum;
                }
                if (currentSum<0)
                {
                    currentSum = 0;
                    sb.Clear();
                }
            }
            Console.WriteLine("The best sequence is: \" {0} \" ", bestSequance);
            Console.WriteLine("The best sum is: {0} ", bestSum);

        }
    }
}
