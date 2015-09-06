/*
* 5. Write a method that calculates the number of workdays between 
* today and given date, passed as parameter. Consider that workdays
* are all days from Monday to Friday except a fixed list of public 
* holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;

namespace _05.Workdays
{
    class Program
    {
        public class Workdays
        {
            public static IList<DateTime> Holidays= new List<DateTime>
            {
                new DateTime(2013, 7, 12), new DateTime(2013, 7, 16), new DateTime(2013, 7, 17),
                new DateTime(2013, 7, 22), new DateTime(2013, 7, 23), new DateTime(2013, 7, 24),
                new DateTime(2013, 7, 26), new DateTime(2013, 7, 30), new DateTime(2013, 7, 31),
                new DateTime(2013, 8, 6), new DateTime(2013, 8, 13), new DateTime(2013, 8, 20),
                new DateTime(2013, 8, 27), new DateTime(2013, 9, 3), new DateTime(2013, 9, 10)
            };

            public static int GetNumberOfWorkdays(DateTime startDate, DateTime endDate)
            {
                int numberOfWorkDays = 0;

                if (startDate > endDate)
                {
                    DateTime swap = startDate;
                    startDate = endDate;
                    endDate = swap;
                }

                while (startDate <= endDate)
                {
                    if (!Holidays.Contains(startDate) && startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        numberOfWorkDays++;
                    }
                    startDate.AddDays(1);
                }

                return numberOfWorkDays;
            }

        }
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2013, 7, 1);
            DateTime end = new DateTime(2013, 9, 30);

            Console.WriteLine("Numbers of workdays for this period is: {0}", Workdays.GetNumberOfWorkdays(start, end));
        }

        
    }
}
