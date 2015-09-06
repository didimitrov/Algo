/*
* 25. Write a program that extracts from given HTML file its title
* (if available), and its body text without the HTML tags. 
*
*  ________________________Example:___________________________
*  | <html>                                                  |
*  |  <head><title>News</title></head>                       |
*  |  <body><p><a href="http://academy.telerik.com">Telerik  |
*  |    Academy</a>aims to provide free real-world practical |
*  |    training for young people who want to turn into      |
*  |    skillful .NET software engineers.</p></body>         |
*  | </html>                                                 |
*  |_________________________________________________________|
*/

using System;
using System.Text.RegularExpressions;

namespace _25.ExtractHtmlTagTitleAndBody
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            if (text != null)
            {
                var xml = Regex.Matches(text, @"(?<=^|>)[^><]+?(?=<|$)");

                foreach (var i in xml)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
