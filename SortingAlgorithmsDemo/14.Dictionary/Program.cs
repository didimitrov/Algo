/*
* 14. A dictionary is stored as a sequence of text lines containing words
* and their explanations. Write a program that enters a word and translates 
* it by using the dictionary. Sample dictionary:
* 
* .NET – platform for applications from Microsoft
* CLR – managed execution environment for .NET
* namespace – hierarchical organization of classes
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace _14.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            StreamReader reader = new StreamReader(@"..\..\Dictionary.txt");

            using (reader)
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var wordsArr = line.Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries);

                    var word = wordsArr[0];
                    var explanation = wordsArr[1];

                    dictionary.Add(word, explanation);

                    line = reader.ReadLine();
                }
            }

            var inputWord = Console.ReadLine();

            if (inputWord != null && !dictionary.ContainsKey(inputWord))
            {
                Console.WriteLine("NO such word in this dictionary");
            }
            Console.WriteLine("{0} - {1}", inputWord, dictionary[inputWord]);
        }
    }
}
