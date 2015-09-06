namespace ConsoleApplication1
{
    public class CostomLinkedItem<T>
    {
        public T Value { get; private set; }
        public CostomLinkedItem<T> NextItem { get;  set; }

        public CostomLinkedItem(T value, CostomLinkedItem<T> nextItem)
        {
            NextItem = nextItem;
            Value = value;
        }

        public CostomLinkedItem(T value) 
            : this(value,null)
        {
            this.Value = value;
        }
    }
}
