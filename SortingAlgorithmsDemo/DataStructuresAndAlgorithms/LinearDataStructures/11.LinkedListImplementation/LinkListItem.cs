

namespace _11.LinkedListImplementation
{
    public class LinkListItem<T>
    {
        public LinkListItem(T value)
        {
            this.Value = value;
            
        }

        public T Value { get; set; }

        public LinkListItem<T> Next{ get; set; }
    }
}
