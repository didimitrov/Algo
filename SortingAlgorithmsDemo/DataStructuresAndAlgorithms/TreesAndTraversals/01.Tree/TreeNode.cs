using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.Tree
{
    public class TreeNode<T>:IEnumerable
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Childrens { get; set; }
        public bool HasParent { get; set; }

        public int Count { get { return this.Childrens.Count; } }

        public TreeNode()
        {
            this.Childrens=new List<TreeNode<T>>();
            
        }

        public TreeNode(T value):this()
        {
            this.Value = value;
        }

        public void AddChild(TreeNode<T> child)
        {
            this.Childrens.Add(child);
            child.HasParent = true;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
