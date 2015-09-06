/*
* 21. Write a program that reads a string from the console and prints
* all different letters in the string along with information how many
* times each letter is found. 
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _21.CharOccurs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input != null)
            {
                char[] inputInCharArray = input.ToCharArray();

                var result = new Dictionary<char, int>();

              //  var differentLetters = inputInCharArray.Distinct().ToArray();

                foreach (char ch in inputInCharArray)
                {
                    if (!result.ContainsKey(ch))
                    {
                        result.Add(ch, 1);
                    }
                    result[ch]++;
                }

               // var sortedList = result.OrderBy(x => x.Key);

                Console.WriteLine("\nLetter occurence table:\n{0}\n",
           string.Join("\n", result.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
            }
        }
    }
}
