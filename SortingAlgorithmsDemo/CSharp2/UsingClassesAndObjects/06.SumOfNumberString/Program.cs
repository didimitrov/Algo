/* You are given a sequence of positive integer 
 * values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. Example:
 * string = "43 68 9 23 318"  result = 461
 */

using System;

namespace _06.SumOfNumberString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            string input = Console.ReadLine();
            if (input != null)
            {
                string[] strArray = input.Split();

                int[] numbers = new int[strArray.Length];

                for (int i = 0; i < strArray.Length; i++)
                {
                    numbers[i] = int.Parse(strArray[i]);
                }

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i];
                }

                Console.WriteLine("Sum: {0}", sum);
            }

          
        }
    }
}
