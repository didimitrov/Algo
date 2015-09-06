/*
 * Write a program that reads N integers from the console 
 * and reverses them using a stack. Use the Stack<int> class.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _02.ReverseStack
{
  public class Program
    {
        public static string ReverseStack(Stack<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }

            var sb = new StringBuilder();

            while (numbers.Count != 0)
            {
                sb.Append(numbers.Pop());
            }

            return sb.ToString().Trim(' ', ',');
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            var n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>(n);


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element[{0}]", i);
                int inputNumber = int.Parse(Console.ReadLine());
                numbers.Push(inputNumber);
            }

            Console.WriteLine(ReverseStack(numbers));
        }
    }
}
