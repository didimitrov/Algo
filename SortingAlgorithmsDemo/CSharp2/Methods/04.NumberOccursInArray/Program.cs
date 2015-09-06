/*
* 4. Write a method that counts how many times given number
* appears in given array. Write a test program to check if 
* the method is working correctly.
*/
using System;

namespace _04.NumberOccursInArray
{
    class Program
    {
        public static int GetNumberOfOccurs(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of the array.");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            Console.WriteLine("Enter elements in the array.");
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Element[{0}]", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter number to occur.");
            int numberToOccur = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is occur {0} times", GetNumberOfOccurs(arr, numberToOccur));
        }
    }
}
