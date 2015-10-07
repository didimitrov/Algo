using System.Collections.Generic;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Components
{
    class HardDrive:IStorage
    {
        private readonly IDictionary<int, string> _data;
        private int _capacity;

        public HardDrive(int capacity)
        {
            this.Capacity = capacity;
            this._data = new Dictionary<int, string>(Capacity);
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public IDictionary<int, string> Data
        {
            get { return _data; }
        }

        public void SaveData(int address, string newData)
        {
            this.Data[address] = newData;

        }

        public string LoadData(int address)
        {
           return this.Data[address];
        }
    }
}
