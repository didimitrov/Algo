using System;
using System.Linq;

namespace _01.SearchAndSort
{
    class Program
    {
        //public static void Swap(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //}

        static void Main(string[] args)
        {
            var inputToArray =
                Console.ReadLine()
                    .Split(new char[','], StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        }
    }
}
