/*
* 17. Write a program that reads a date and time given in the format:
* day.month.year hour:minute:second 
* and prints the date and time after 6 hours and 30 minutes (in the same format)
* along with the day of week in Bulgarian.
*/

using System;

namespace _17.PrintDaysOfWeekAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dateInputString = Console.ReadLine();

            //if (dateInputString != null)
            //{
            //    var date = DateTime.ParseExact(dateInputString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //    date.AddHours(6.5);

            //    Console.WriteLine(date.ToString());
            //}

            Console.WriteLine("Enter date in format - day.month.year hour:minute:second");
            string input = Console.ReadLine();

            if (input != null)
            {
                string[] dateArray = input.Split(new[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var dateObj = new DateTime(int.Parse(dateArray[2]), int.Parse(dateArray[1]), int.Parse(dateArray[0]),
                    int.Parse(dateArray[3]), int.Parse(dateArray[4]), int.Parse(dateArray[5]));

                var resultDate = dateObj.AddHours(6.5);

                Console.WriteLine(resultDate);
            }
        }
    }
}
