using System;
using System.Collections.Generic;

namespace _01.SearchAndSort
{
    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly List<T> items;

        public SortableCollection()
        {
            this.items=new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items=new List<T>(items);
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool BinarySearch(T element)
        {
            var indexMax = this.items.Count - 1;
            var indexMin = 0;

            while (indexMax >= indexMin)
            {
                int midElementIndex = (indexMax + indexMin)/2;

                if (this.items[midElementIndex].CompareTo(element) < 0)
                {
                    indexMin = midElementIndex + 1;
                }
                if (this.items[midElementIndex].CompareTo(element) > 0)
                {
                    indexMax = midElementIndex - 1;
                }
                else
                {
                    return true;
                }
               
            }
            return false;
        }

        public void Shuffle()
        {
            var rnd = new Random();

            for (int i = 0; i < this.items.Count; i++)
            {
                var j = rnd.Next(i, items.Count);

                T temp = items[j];
                items[j] = items[i];
                items[i] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
