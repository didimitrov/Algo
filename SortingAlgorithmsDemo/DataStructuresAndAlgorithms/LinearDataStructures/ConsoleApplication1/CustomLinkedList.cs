using System;

namespace ConsoleApplication1
{
    public class CustomLinkedList<T>
    {
        private  CostomLinkedItem<T> _firstItem;

        public CustomLinkedList()
        {
            CountElements = 0;
            _firstItem = null;
        }

        public T FirstItem
        {
            get { return _firstItem.Value; }
        }

        public int CountElements { get; private set; }

        public void Add(int index, T value)
        {
            var currentItem = this._firstItem;

            if (index < 0 || index>this.CountElements)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index == 0)
            {
                this._firstItem = new CostomLinkedItem<T>(value, currentItem);
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                {
                    currentItem = currentItem.NextItem;
                }

                currentItem.NextItem = new CostomLinkedItem<T>(value, currentItem.NextItem);
            }

            this.CountElements++;
        }

        public void AddFirst(T value)
        {
            this.Add(0, value);
        }

        public void AddLast(T value)
        {
            this.Add(this.CountElements, value);
        }

        public void RemoveAt(int index)
        {
            var currentItem = this._firstItem;

            if (index<0 || index>=this.CountElements)
            {
                throw  new ArgumentOutOfRangeException();
            }
            if (index == 0)
            {
                this._firstItem = currentItem.NextItem;
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                {
                    currentItem = currentItem.NextItem;
                }
                currentItem.NextItem = currentItem.NextItem.NextItem;
            }

            CountElements--;
        }

        public void RemoveLast()
        {
            this.RemoveAt(CountElements-1);
        }

        public void RemoveFirst()
        {
            RemoveAt(0);
        }
    }
}
