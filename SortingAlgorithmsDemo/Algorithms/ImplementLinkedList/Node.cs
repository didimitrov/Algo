﻿namespace ImplementLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> NextNode { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }

        
    }
}
