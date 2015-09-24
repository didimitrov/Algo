/* 
     * Write a program that counts how many times each 
     * word from given text file words.txt appears in it.
     * The character casing differences should be ignored.
     * The result words should be ordered by their number 
     * of occurrences in the text. 
     * 
     * Example:
     * is  2
     * the  2
     * this  3
     * text  6 
     */

using System;
using System.Collections.Generic;
using System.IO;

namespace _03.CountWordsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();

            var text = string.Empty;

            using (var reader = new StreamReader(@"..//..//input.txt"))
            {
              text = reader.ReadToEnd().ToLower();
            }

            string[] words = text.Split(new char[] {' ', ',', '-', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (dictionary.ContainsKey(words[i]))
                {
                    dictionary[words[i]]++;
                }
                else
                {
                    dictionary.Add(words[i], 1);
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
    }
}
