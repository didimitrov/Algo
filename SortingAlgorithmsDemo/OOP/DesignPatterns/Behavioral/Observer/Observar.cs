using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Observar : IOserverable
    {
        public string Name { get; private set; }

        public Observar(string name)
        {
            this.Name = name;
        }

        public void Update()
        {
            Console.WriteLine("{0}: A new product has arrived at the store",this.Name);
        }
    }

    public interface IOserverable
    {
        void Update();
    }
}
