using System.Linq;

namespace _06.PrintNumbersDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            //06.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            int[] numbers = new int[] { 3, 15, 21, 19, 42, 7, 55, 29, 84, 99, 168 };

            var extensionResul = numbers.Where(x => x % 21 == 0);

            var linqResult = from number in numbers
                where number%21==0
                select number;
        }
    }
}
