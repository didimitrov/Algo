using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Element
    {
        private int displayDepthLevel = 0;
        private const int DisplayDepthSpaces = 2;

        private ICollection<Element> _subElements;
        private string _type;

        public Element(string type, params Element[] subElements)
        {
            this.SubElements = subElements;
            this.Type = type;
        }

        public ICollection<Element> SubElements
        {
            get { return _subElements; }
            set { _subElements = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void Add(Element element)
        {
            if (element == null)
            {
                throw new InvalidOperationException("Child cannot be null!");
            }
            SubElements.Add(element);
        }

        public void Remove(Element element)
        {
            if (element == null)
            {
                throw new InvalidOperationException("Child cannot be null!");
            }
            SubElements.Remove(element);
        }

        public string Display()
        {
            var result = this.Display(this, new StringBuilder());
            return result.ToString();
        }

        private StringBuilder Display(Element node, StringBuilder currentTree)
        {
            // Open tag
            currentTree.Append(new string(' ', this.displayDepthLevel * DisplayDepthSpaces))
                .Append("<")
                .Append(node.Type)
                .Append(">")
                .AppendLine();
            this.displayDepthLevel++;

            foreach (var child in node.SubElements)
            {
                currentTree = this.Display(child, currentTree);
            }

            // Closing tag
            this.displayDepthLevel--;
            currentTree.Append(new string(' ', this.displayDepthLevel * DisplayDepthSpaces))
                .Append("<")
                .Append(node.Type)
                .Append("/>")
                .AppendLine();

            return currentTree;
        }
    }
}
