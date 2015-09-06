/* Write a method that reverses the digits of 
 * given decimal number. Example: 256  652  
 */
using System;
using System.Text;

namespace _07.ReverseDigits
{
    class Program
    {
        static string ReverseDigits(string inputNumber)
        {
            var sb = new StringBuilder();
            for (int i = inputNumber.Length-1; i >= 0; i--)
            {
                sb.Append(inputNumber[i]);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            const string myString = "1234556.5360";
            Console.WriteLine("Reversed number is: {0}", ReverseDigits(myString));
        }
    }
}
