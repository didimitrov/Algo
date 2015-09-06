using System;

namespace _05.MaxIncreasingSequence
{
    /* Write a program that finds the maximal
 * increasing sequence in an array. Example: 
 * {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 3, 2, 3, 4, 2, 2, 4 };

            int bestLenght = 0;
            int currentLenght = 1;
            int element = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1] - 1)
                {
                    currentLenght++;
                }
                else
                {
                    if (bestLenght < currentLenght)
                    {
                        bestLenght = currentLenght;
                        element = i;
                    }
                    currentLenght = 1;
                }
            }
            //print
            Console.Write("the best increasing sequence is: {");
            for (int i = element - bestLenght + 1; i <= element; i++)
            {
                Console.Write((arr[i]) + " ");
            }
            Console.WriteLine("}");
        }
    }
}
