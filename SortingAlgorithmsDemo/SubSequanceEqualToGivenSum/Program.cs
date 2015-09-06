//11. Да се напише програма, която намира последователност от числа в
//масив, които имат сума равна на число, въведено от конзолата (ако
//има такава). Пример: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}.

using System;
using System.Text;

namespace SubSequanceEqualToGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };

            Console.WriteLine("Enter sum: ");
            int s = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var sequance = "";

            int currentSum = 0;
            int startElement = 0;
            int lastElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == s)
                    {
                        startElement = i;
                        lastElement = j;
                    }
                    if (currentSum > s)
                    {
                        currentSum = 0;
                        break;
                    }
                }

            }

            for (int i = startElement; i <= lastElement; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
    }
}

