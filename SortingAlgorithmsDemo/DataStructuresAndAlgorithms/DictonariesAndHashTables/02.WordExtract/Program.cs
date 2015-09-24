/*
    * Write a program that extracts from a given sequence of strings 
    * all elements that present in it odd number of times. 
    * Example:{C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}
    */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.WordExtract
{
    class Program
    {
        static void Main(string[] args)
        {
             // test input
             //6
             //C#
             //SQL
             //PHP
             //PHP
             //SQL
             //SQL

            Console.WriteLine("ENTER LENGTH OF THE SEQUANCE: ");
            var length = int.Parse(Console.ReadLine());

            var sequance = new List<string>(length);

            var dictionaryCountEl = new Dictionary<string, int>();

            for (int i = 0; i < length; i++)
            {
                var stringElement = Console.ReadLine();

                sequance.Add(stringElement);

                if (stringElement != null && dictionaryCountEl.ContainsKey(stringElement))
                {
                    dictionaryCountEl[stringElement]++;
                }
                else
                {
                    dictionaryCountEl.Add(stringElement, 1);
                }
            }

            var elementsWhitOddOccurence = dictionaryCountEl.Where(x => x.Value%2 == 1).Select(x => x.Key);

            Console.WriteLine("{0}", String.Join(",", elementsWhitOddOccurence));
        }
    }
}
