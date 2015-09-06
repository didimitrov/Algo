/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

using System;

namespace _03.CheckBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int brackerCounter = 0;

            if (input==null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    brackerCounter++;
                }
                brackerCounter--;
            }

            if (brackerCounter==0)
            {
                Console.WriteLine("Brackets are ok!");
            }
            Console.WriteLine("Brackets are incorrect!");
        }
    }
}
