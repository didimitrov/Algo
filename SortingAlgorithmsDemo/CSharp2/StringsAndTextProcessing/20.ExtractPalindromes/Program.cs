/*
* 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/

using System;

namespace _20.ExtractPalindromes
{
    class Program
    {
        static bool IsPalindrom(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]!= word[word.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            const string word = "THIS IS NOT PALINDROME";

            Console.WriteLine("The word is polindrom: {0}", IsPalindrom(word));
        }
    }
}
