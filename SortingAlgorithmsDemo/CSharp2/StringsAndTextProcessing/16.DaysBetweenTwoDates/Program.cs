/*
* 16. Write a program that reads two dates in the format: day.month.year
* and calculates the number of days between them. 
* 
* Example:
* Enter the first date: 27.02.2006
* Enter the second date: 3.03.2006
* Distance: 4 days
*/

using System;

namespace _16.DaysBetweenTwoDates
{
    class Program
    {
        static DateTime GetDateFromString(string data)
        {
            string[] dataArray = data.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

            int days = int.Parse(dataArray[0]);
            int months = int.Parse(dataArray[1]);
            int years = int.Parse(dataArray[2]);

            return new DateTime(years, months, days);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first date: ");
            string firstDateString = Console.ReadLine();
            Console.Write("Enter second date: ");
            string secondDateString = Console.ReadLine();

            var firstDateObj = GetDateFromString(firstDateString);
            var secondDateObj = GetDateFromString(secondDateString);

            var result = Math.Abs(firstDateObj.Subtract(secondDateObj).TotalDays);

            Console.WriteLine(result);
        }
    }
}
