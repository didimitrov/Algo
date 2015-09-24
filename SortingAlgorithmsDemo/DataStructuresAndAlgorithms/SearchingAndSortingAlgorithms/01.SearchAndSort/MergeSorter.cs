using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SearchAndSort
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IList<T> Mergesorter(IList<T> collection)
        {
            if (collection.Count<= 1)
            {
                return collection;
            }

            var left = new List<T>();
            var right = new List<T>();
            var mid = collection.Count/2;

            for (int i = 0; i < mid; i++)
            {
               // left[i] = collection[i];
                left.Add(collection[i]);
            }
            for (int i = mid; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }

            return Merge(Mergesorter(left), Mergesorter(right));
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            var result = new List<T>();

            while (left.Any() && right.Any())
            {
                if (left[0].CompareTo(right[0]) < 1)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }

            while(left.Any())
            {
                 result.Add(left[0]);
                left.RemoveAt(0); 
            }
           
            while(right.Any())
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }


        public void Sort(IList<T> collection)
        {
            var sortedCollection = Mergesorter(collection);
            collection.Clear();

            for (int i = 0; i < sortedCollection.Count; i++)
            {
               // collection[i] = sortedCollection[i];
                collection.Add(sortedCollection[i]);
            }
        }
    }
}
