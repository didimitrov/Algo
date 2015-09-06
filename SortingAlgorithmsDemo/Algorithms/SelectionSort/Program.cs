using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 132, 45, -2, 333 };

            var sorted= SelectionSort(myArray);

            foreach (var i in sorted)
            {
                Console.Write(i+ " ");
            }
        }

        public static int[] SelectionSort(int[] arr)
        {
            var min_pos = 0;
            var temp = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                min_pos = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_pos])
                    {
                        min_pos = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min_pos];
                arr[min_pos] = temp;
            }
            return arr;
        }
    }
}
