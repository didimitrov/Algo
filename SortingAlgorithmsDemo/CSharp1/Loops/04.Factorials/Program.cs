//Write a program that calculates N!/K! for given N and K (1<K<N)

using System;
using System.Numerics;

namespace _04.Factorials
{
    class Program
    {
        static BigInteger CalculateFactorial(int number)
        {
            BigInteger sum = 1;

            for (int i = 0; i < number; i++)
            {
                sum = sum*i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = Int16.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = Int16.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(n)/CalculateFactorial(k));
        }
    }
}
