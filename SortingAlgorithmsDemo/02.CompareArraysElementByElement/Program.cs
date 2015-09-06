using System;

namespace _02.CompareArraysElementByElement
{
    //Write a program that reads two arrays from the console and compares them element by element.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of first array.");
            var firstArrSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of second array.");
            var secondArrSize = int.Parse(Console.ReadLine());

            var firstArr = new int[firstArrSize];
            var secondArr = new int[secondArrSize];

            Console.WriteLine("Enter numbers for first array");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter numbers for second array");
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i]==secondArr[j])
                    {
                        Console.WriteLine("first array element[{0}] = second array element[{1}] = {2} ", i, j, firstArr[i]);
                    }
                }
            }
        }
    }
}
