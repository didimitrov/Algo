
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _03._1.CheckBracketsWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> brackets = new Stack<string>();

            bool isCorrect = true;

            if (input == null)
            {
                throw  new ArgumentNullException();
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets.Push(input[i].ToString(CultureInfo.InvariantCulture));
                }
                if (input[i] == ')')
                {
                    if (brackets.Count == 0)
                    {
                        isCorrect = false;
                        break;
                    }
                    brackets.Pop();
                }
                if (brackets.Count != 0)
                {
                    isCorrect = false;
                }

                Console.WriteLine("Is the brackets correct: {0}", isCorrect);
            }

        }
    }
}
