/* 
 Write a program that finds the sequence of maximal sum in given array.
 */

using System;
using System.Linq;
using System.Text;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            //string input = Console.ReadLine();
            //if (input != null)
            //{
            //    int[] sequence = input.Split(' ').Select(int.Parse).ToArray();

                int bestSum = 0;
                StringBuilder bestSequenceBuild = new StringBuilder();
                string bestSequence = "";
                int currentSum = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    currentSum = currentSum + sequence[i];
                    bestSequenceBuild.AppendFormat("{0}, ", sequence[i]);

                    if (currentSum>bestSum)
                    {
                        bestSum = currentSum;
                        bestSequence = bestSequenceBuild.ToString();
                    }
                    if (currentSum<0)
                    {
                        currentSum = 0;
                        bestSequenceBuild.Clear();
                    }
                }

                Console.WriteLine("Best sequence is: \"{0}\" ",bestSequence);
                Console.WriteLine("Best sum is: {0}", bestSum);
            }
       // }
    }
}
