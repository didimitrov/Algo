namespace WebScraper
{
    using System.Collections.Generic;

    public class WebPageRepository
    {
        private readonly Queue<string> _addresses;
        private static readonly object Locker = new object();
        private static WebPageRepository Instance;

        public static WebPageRepository GetInstance()
        {
            if (Instance==null)
            {
                lock (Locker)
                {
                    if (Instance==null)
                    {
                        return Instance=new WebPageRepository();
                    }
                }
            }
            return Instance;
        }

        private WebPageRepository()
        {
            this._addresses = new Queue<string>();
            this.Seed();
        }

        public bool IsEmpty
        {
            get
            {
                return this._addresses.Count == 0;
            }
        }

        public void Add(string address)
        {
            this._addresses.Enqueue(address);
        }

        public string Remove()
        {
            return this._addresses.Dequeue();
        }

        private void Seed()
        {
            this._addresses.Enqueue("https://softuni.bg/");
            this._addresses.Enqueue("http://stackoverflow.com/");
            this._addresses.Enqueue("https://www.youtube.com/");
            this._addresses.Enqueue("https://www.google.bg/");
        }
    }
}
