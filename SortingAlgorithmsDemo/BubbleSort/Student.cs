using System;

namespace BubbleSort
{
    public class Student
    {

        public int FakNumber { get; set; }
        public string Name { get; set; }

        public Student()
        {
            this.Name = "Miti";
            this.FakNumber = 0;
        }

        public Student(int f,string n )
        {
            this.FakNumber = f;
            this.Name = n;
        }

        //public Student(int fakNumber, string name)
        //{
        //    Name = name;
        //    FakNumber = fakNumber;
        //}

        //public int FakNumber { get; private set; }
        //public string Name { get; private set; }

        public void SortArray2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
