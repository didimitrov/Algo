/* Write a method that checks if the element at 
 * given position in given array of integers is 
 * bigger than its two neighbors (when such exist).
 */
using System;

namespace _05.BiggerFromItsNeighbours
{
    class Program
    {
        private static bool FindBiggerNeighbor(int[] array, int index)
        {
            if (index == 0 && array.Length == 1)
            {
                return false;
            }
            if (index == 0 && array.Length > 1)
            {
                if (array[index]>array[index + 1])
                {
                    return true;
                }
                return false;
            }
            if (index + 1 == array.Length && array.Length > 1)
            {
                if (array[index] > array[index-1])
                {
                    return true;
                }
                return false;
            }
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            const int position = 1;
            int[] myArray = { 1, 2, 1 };
            Console.WriteLine("The element on position {0} is bigger then its neighbors: {1}", position, FindBiggerNeighbor(myArray, position));
        }
    }
}
