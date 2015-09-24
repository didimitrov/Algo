using System;
using System.Collections.Generic;

namespace _01.SearchAndSort
{
    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IList<T> QuickSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            var pivot = (collection.Count - 1)/2;
            var pivotValue = collection[pivot];

            collection.RemoveAt(pivot);

            var lesser = new List<T>();
            var greater = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(pivotValue)<1)
                {
                    lesser.Add(collection[i]);
                }
                else
                {
                    greater.Add(collection[i]);
                }
            }

            var result = new List<T>();
            result.AddRange(QuickSort(lesser));
            result.Add(pivotValue);
            result.AddRange(QuickSort(greater));

            return result;
        } 



        public void Sort(IList<T> collection)
        {
            if (collection==null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count<=1)
            {
                return;
            }

            var sortedCollection = QuickSort(collection);

            collection.Clear();

            for (int i = 0; i < sortedCollection.Count; i++)
            {
                collection.Add(sortedCollection[i]);
            }
        }
    }
}