/*
* 24. Write a program that reads a list of words, separated by
* spaces and prints the list in an alphabetical order.
*/

using System;
using System.Linq;

namespace _24.SortAlphabetcal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == null)
            {
                throw new ArgumentNullException();
            }

            string[] words = input.Split(' ');

            var sortedWords = words.OrderBy(x => x);

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
