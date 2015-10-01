using System;
using System.Collections.Generic;

namespace Observer
{
    class Subject : ISubject
    {
        private List<IOserverable> _observers;
        private int _data;

        public Subject(int data)
        {
            this.Data = data;
            this.Observers = new List<IOserverable>();
        }

        public List<IOserverable> Observers
        {
            get { return _observers; }
            set { _observers = value; }
        }

        public int Data
        {
            get { return _data; }
            set
            {
                if (value!=Data)
                {
                    Notify();
                }
                _data = value;
            }
        }

        public void Subscribe(IOserverable observer)
        {
            this.Observers.Add(observer);
        }

        public void Unsubscribe(IOserverable observer()
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            this.Observers.ForEach(x=>x.Update());
        }
    }

    public interface ISubject
    {
        void Subscribe(IOserverable observer);
        void Unsubscribe(IOserverable observer);
        void Notify();
    }
}
