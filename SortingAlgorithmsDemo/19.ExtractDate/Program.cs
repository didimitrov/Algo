/*
* 19. Write a program that extracts from a given text all dates that
* match the format DD.MM.YYYY. Display them in the standard date format for Canada.
* 
* Sample text:
* I was born at 14.06.1980. My sister was born at 3.7.1984. In
* 5/1999 I graduated my high school. The law says (see section
* 7.3.12) that we are allowed to do this (section 7.4.2.9).
* 
* Extracted dates from the sample text:
* 14.06.1980
* 3.7.1984
* 
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _19.ExtractDate
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input != null)
            {
                var dates = Regex.Matches(input, @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b");

                foreach (var date in dates)
                {
                    var dateObj = DateTime.Parse(date.ToString());
                    Console.WriteLine(dateObj.ToString(CultureInfo.GetCultureInfo("en-CA")));
                }

            }
        }
    }
}
