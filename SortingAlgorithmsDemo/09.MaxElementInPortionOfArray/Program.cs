/*
* 9. Write a method that return the maximal element in a portion
* of array of integers starting at given index. 
* Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Runtime.CompilerServices;

namespace _09.MaxElementInPortionOfArray
{
    class Program
    {
        public static int GetMaxInPartition(int[] arr, int index)
        {
            var biggest = index;
            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[biggest])
                {
                    biggest = i;
                }
            }
            return biggest;
        }

        public static void ArraySwap(int[] array, int firstNumberindex, int secondNumberIndex)
        {
            var temp = array[firstNumberindex];
            array[firstNumberindex] = array[secondNumberIndex];
            array[secondNumberIndex] = temp;
        }

        public static int[] SelectionSort(int[] array, bool assending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var max = GetMaxInPartition(array, i);
                ArraySwap(array,i, max);
            }
            if (assending)
            {
                Array.Reverse(array);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 147, 3, 4, 5, 6, 7, 20, 9, 10 };
            Console.WriteLine("Max element in a portion of array");
            Console.WriteLine(myArray[GetMaxInPartition(myArray, 4)]);

            Console.WriteLine("Selection sort");
            myArray = SelectionSort(myArray, true);
            foreach (var item in myArray)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
