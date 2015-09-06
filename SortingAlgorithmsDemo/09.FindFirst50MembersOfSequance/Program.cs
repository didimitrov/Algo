/*
 * 9. We are given the following sequence:
	S1 = N;
	S2 = S1 + 1;
	S3 = 2*S1 + 1;
	S4 = S1 + 2;
	S5 = S2 + 1;
	S6 = 2*S2 + 1;
	S7 = S2 + 2;
	...
	Using the Queue<T> class write a program to print its first 50 members for given N.
	Example: N=2 ? 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _09.FindFirst50MembersOfSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 2;
            Queue<int> queue = new Queue<int>();
            StringBuilder output = new StringBuilder();

            queue.Enqueue(n);

            for (int i = 0; i < 13; i++)
            {
                var current = queue.Dequeue();

                output.AppendFormat("{0},{1},{2}", current + 1, (2*current) + 1, current + 2);

                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(output.ToString().Trim(' ',','));

            Console.ResetColor();
        }
    }
}
