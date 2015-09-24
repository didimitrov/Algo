using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _13.QueueImplementation
{
    public class CustomQueue<T> : IEnumerable
    {
        private LinkedList<T> innerList;

        public CustomQueue()
        {
            this.innerList = new LinkedList<T>();
        }

        public void Enqueue(T element)
        {
            this.innerList.AddLast(element);
        }

        public int Count { get { return this.innerList.Count; } }

        public T Dequeue()
        {
            if (this.innerList.Count==0)
            {
                throw new InvalidOperationException();
            }
            var removedElement = this.innerList.First.Value;
            this.innerList.RemoveFirst();

            return removedElement;
        }

        public bool Contains(T element)
        {
            return this.innerList.Contains(element);
        }

        public T[] ToArray()
        {
            T[] copiedArray = new T[this.Count];
            this.innerList.CopyTo(copiedArray, 0);
            return copiedArray;
        }

        public void Clear()
        {
            this.innerList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return this.innerList.GetEnumerator();
        }
    }
}
