using System;
using System.Collections.Generic;

namespace _01.SearchAndSort
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count-1; i++)
            {
                var minElementIndex = i;

                for (int j = i+1; j < collection.Count; j++)
                {
                    if (collection[minElementIndex].CompareTo(collection[j]) > 0)
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    var tmp = collection[i];
                    collection[i] = collection[minElementIndex];
                    collection[minElementIndex] = tmp;
                }
            }
        }
    }
}
