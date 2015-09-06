/* Write a program to calculate n! for each n in 
 * the range [1..100]. Hint: Implement first a 
 * method that multiplies a number represented 
 * as array of digits by given integer number. 
 */
using System;
using System.Numerics;

namespace _10.BigFactorial
{
    class Program
    {
        public static BigInteger GetFactorial(int number)
        {
            BigInteger product = 1;

            for (int i = number; i > 0 ; i--)
            {
                product = product*i;
            }
            return product;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("Factorial of {0} is {1}", i , GetFactorial(i));
            }
        }
    }
}
