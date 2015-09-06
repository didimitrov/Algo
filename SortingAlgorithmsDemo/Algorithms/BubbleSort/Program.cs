using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BubbleSort
{
    class Program
    {
        public static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }               
            }
            foreach (var t in arr)
                Console.Write(t + " ");
        }

        private static void Main()
        {
            var arr = new[] { 800, 11, 50, 771, 649, 770, 240, 9 };
            SortArray(arr);

           
           // var students = new List<Student>
           // {
           //     new Student(123, "Miti"),
           //     new Student(3746, "Niki"),
           //     new Student(9876, "Stuz"),
           //     new Student(222, "Ani"),
           // };
            
           //// Array.Sort(students, (x, y) => String.CompareOrdinal(x.Name, y.Name));
           // students.Sort((x, y) => String.CompareOrdinal(x.Name, y.Name));
           // foreach (var student in students)
           // {
           //     Console.WriteLine(student.Name);
           // }
        }
    }
}
