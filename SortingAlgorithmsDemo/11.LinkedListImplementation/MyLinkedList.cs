

using System;

namespace _11.LinkedListImplementation
{

    //chrome-extension://klbibkeccnjlkjkiokjodocebajanakg/suspended.html#uri=http://stackoverflow.com/questions/20943233/remove-method-for-linkedlist-implementation-in-java
    class MyLinkedList<T>
    {
        public LinkListItem<T> FirstItem { get; private set; }
     //   public LinkListItem<T> LastItem { get; private set; }
        public int ElementCount { get; private set; }


        public MyLinkedList()
        {
            this.FirstItem = null;
           // this.LastItem = null;
            this.ElementCount = 0;
        }

        public void AddFirst(T value)
        {
            if (FirstItem == null)
            {
                this.FirstItem = new LinkListItem<T>(value);
       //         this.LastItem = FirstItem;
            }
            else
            {
                var newItem = new LinkListItem<T>(value);
                newItem.Next = FirstItem;
                FirstItem = newItem;
            }
            ElementCount++;

        }

        public void AddLast(T value)
        {
            if (FirstItem == null)
            {
                this.FirstItem = new LinkListItem<T>(value);
         //       this.LastItem = FirstItem;
            }
            else
            {
                var newItem = new LinkListItem<T>(value);
                this.FirstItem.Next = FirstItem;
                this.FirstItem = newItem;
                //this.LastItem.Next = newItem;
                //this.LastItem = newItem;
            }
            this.ElementCount++;
        }

        public void RemoveFirst()
        {
            if (this.FirstItem==null)
            {
                throw new ArgumentNullException("List is empty.");
            }
            this.FirstItem = this.FirstItem.Next;
            this.ElementCount--;
        }

        public void RemoveAt(int index)
        {
            var currentNode = FirstItem;

            if (index == 0)
            {
                this.FirstItem = this.FirstItem.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = currentNode.Next.Next;
            }
            ElementCount--;
        }

        public void Clear()
        {
            //this.FirstItem = null;
            //this.ElementCount = 0;

            while (this.FirstItem!=null)
            {
                this.FirstItem = this.FirstItem.Next;
                this.ElementCount--;
            }
        }



        public void RemoveF()
        {
            RemoveAt(0);
        }
        public void RemoveL()
        {
            RemoveAt(this.ElementCount-1);
        }
    }
}
