/*
* 22. Write a program that reads a string from the console and lists
* all different words in the string along with information how many
* times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _22.WordOccurs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input != null)
            {
                string[] words = input.Split();

                Dictionary<string, int> result = new Dictionary<string, int>();

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (result.ContainsKey(word))
                    {
                        result[word]++;
                    }
                    result.Add(word, 1);
                }

                Console.WriteLine("\nWord occurence table:\n{0}\n",
                                      string.Join("\n", result.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
           
            }

            throw new ArgumentNullException();
        }
    }
}
