/*
* 23. Write a program that reads a string from the console and replaces all
* series of consecutive identical letters with a single one.
* Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
*/

using System;
using System.Text;

namespace _23.ReplaceSequanceWithSingleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sequance = "aaaaabbbbbcdddeeeedssaa";

            var sb = new StringBuilder();

            for (var i = 0; i < sequance.Length - 1; i++)
            {
                if (sequance[i] != sequance[i + 1])
                {
                    sb.Append(sequance[i]);
                }
            }

            // Last Case
            //if (sequance[sequance.Length] != sequance[sequance.Length - 1])
            //{
            //    sb.Append(sequance[sequance.Length]);
            //}

            Console.WriteLine(sb.ToString());
        }
    }
}
