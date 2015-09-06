using System;

namespace _01.InitializationOfArray
{
    //Write a program that allocates array of 20 integers and initializes each element
    //by its index multiplied by 5. Print the obtained array on the console.

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[20];

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = i*5;
            }

            Console.WriteLine(string.Join(",", arr));
        }
    }
}
