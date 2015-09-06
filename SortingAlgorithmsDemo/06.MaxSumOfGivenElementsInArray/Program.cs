/* Write a program that reads two
 * integer numbers N and K and an array
 * of N elements from the console. Find
 * in the array those K elements that have maximal sum.
 */

using System;
using System.Text;

namespace _06.MaxSumOfGivenElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            var bestSum = 0;
            var currentSum = 0;

            var sb = new StringBuilder();
            var sequance = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum = currentSum + numbers[i];
                sb.AppendFormat("{0} ", numbers[i]);

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    sequance = sb.ToString();
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                    sb.Clear();
                }
            }

            Console.WriteLine("Best sum sequance: {0}, best sum: {1}", sequance, bestSum);


            //Console.WriteLine(" Please enter N: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter K: ");
            //int k = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of the array");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Element[{0}]", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxSum = 0;
            //for (int i = 0; i < n-k+1; i++)
            //{
            //    int sum = 0;
            //    for (int j = i; j < i + k; j++)
            //    {
            //        sum = sum + arr[j];
            //    }
            //    if (sum>maxSum)
            //    {
            //        maxSum = sum;
            //    }
            //}

            //Console.WriteLine("The maximal sum of {0} elements is: {1}", k, maxSum);
        }
    }
}
