using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(5);
            // Observer1 takes a subscription to the store
            var observer1 = new Observar("Observer 1");
            subject.Subscribe(observer1);
            // Observer2 also subscribes to the store
            subject.Subscribe(new Observar("Observer 2"));
            subject.Data++;
            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new Observar("Observer 3"));
            subject.Data++;
            Console.ReadLine();
        }
    }
}
