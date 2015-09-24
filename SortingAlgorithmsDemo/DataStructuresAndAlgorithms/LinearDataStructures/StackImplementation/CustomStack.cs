using System;
using System.Collections;

namespace StackImplementation
{
    public class CustomStack<T> : IEnumerable
    {
        //fields
        private const int defSize = 4;
        private T[] innerArray;
        private int stackSize = 0;
        private int maxsize = 4;
        //constructors
        public CustomStack()
        {
            this.innerArray = new T[defSize];
        }

        public CustomStack(int size)
        {
            this.innerArray= new T[size];
        }
        //properties
        public int Count { get { return this.stackSize; } }

        //methods
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in innerArray)
            {
                if (item == null)
                {
                    break;
                }
                yield return item;
            }
        }

        public void Push(T element)
        {
            if (this.stackSize == maxsize)
            {
                this.innerArray = ResizeArr(innerArray);
            }
            this.innerArray[stackSize] = element;
            this.stackSize++;
        }

        public T Pop()
        {
            if (this.stackSize==0)
            {
                throw new InvalidOperationException();
            }
            var popedElement = this.innerArray[stackSize - 1];
            this.innerArray[this.stackSize] = default(T);
            this.stackSize --;

            return popedElement;
        }

        public T Peek()
        {
            if (this.stackSize==0)
            {
                throw new InvalidOperationException();
            }
            var peekedElement = this.innerArray[stackSize - 1];
            return peekedElement;
        }

        public bool Contains(T element)
        {
            bool isContain = false;
            for (int i = 0; i < this.innerArray.Length; i++)
            {
                if (innerArray[i].Equals(element))
                {
                    isContain = true;
                    break;
                }
            }
            return isContain;
        }

        private T[] ResizeArr(T[] innerArray1)
        {
            var newArray = new T[maxsize*2];
            this.maxsize = maxsize*2;

            for (int i = 0; i < innerArray1.Length; i++)
            {
                newArray[i] = innerArray1[i];
            }

            return newArray;
        }
    }
}
