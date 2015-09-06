/*
* 18. Write a program for extracting all email addresses from given text.
* All substrings that match the format <identifier>@<host>…<domain> 
* should be recognized as emails.
* 
* Example:
* Please contact us by phone (+001 222 222 222) or by email at
* example@gmail.com or at test.user@yahoo.co.uk. This is not
* email: test@test. This also: @gmail.com. Neither this: a@a.b.
* 
* Extracted e-mail addresses from the sample text:
* example@gmail.com
* test.user@yahoo.co.uk
*/

using System;
using System.Text.RegularExpressions;

namespace _18.ExtractAllValidEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            //Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.
           
            var input = Console.ReadLine();

            if (input != null)
            {
                var emails = Regex.Matches(input, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}");

                foreach (var email in emails)
                {
                    Console.WriteLine(email.ToString());
                }
            }
        }
    }
}
