/* Sorting an array means to arrange
 * its elements in increasing order.
 * Write a program to sort an array.
 * Use the "selection sort" algorithm:
 * Find the smallest element, move it at the
 * first position, find the smallest from the
 * rest, move it at the second position, etc.
 */

using System;
using System.Runtime.ConstrainedExecution;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 132, 45, -2, 333};

            for (int i = 0; i < arr.Length-1; i++)
            {
                int minElement = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minElement])
                    {
                        minElement = j;
                    }
                }

                //swap values
                int temp = arr[i];
                arr[i] = arr[minElement];
                arr[minElement] = temp;
             }

            foreach (int t in arr)
            {
                Console.Write(t+" ");
            }
        }
    }
}
