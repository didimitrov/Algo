/*
* 15. Write a program that replaces in a HTML document given as string all 
* the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
* 
* Sample HTML fragment:
* ________________________________________________________________________________
* |<p>Please visit <a href="http://academy.telerik.com">our site</a>             |
* |to choose a training course. Also visit <a href="www.devbg.org">our forum</a> |
* |to discuss the courses.</p>                                                   |
* |______________________________________________________________________________|                                  
* ________________________________________________________________________________
* |<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a    |
* |training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the |
* |courses.</p>                                                                  |
* |______________________________________________________________________________|
*/

using System;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace _15.HtmlTagReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();

            html = Regex.Replace(html, @"<a href=""", @"[URL=");
            html = Regex.Replace(html, @""">", @"]");
            html = Regex.Replace(html, @"</a>", @"[/URL]");
            Console.WriteLine(html);
        }
    }
}
