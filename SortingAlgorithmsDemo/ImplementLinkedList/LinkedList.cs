using System.Collections;
using System.Collections.Generic;

namespace ImplementLinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public Node<T> CurrentNode { get; set; }
        public Node<T> HeadNode { get; set; }

        public void Add(T item)
        {
            if (HeadNode==null)
            {
                HeadNode=new Node<T>(item);
                CurrentNode = HeadNode;
            }
            else
            {
                CurrentNode.NextNode = new Node<T>(item);
                CurrentNode = CurrentNode.NextNode;
                Count++;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
