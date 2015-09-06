/*
* 13. Write a program that reverses the words in given sentence.
* Example: 
* "C# is not C++ not PHP and not Delphi!" -> "Delphi not and PHP not C++ not is C#!".
*/

using System;

namespace _13.ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++ not PHP and not Delphi!";

            char sign = text[text.Length - 1];

            text= text.Remove(text.Length - 1, 1);

            string[] words = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            Console.WriteLine(string.Join(" ",words) + sign);
        }
    }
}
