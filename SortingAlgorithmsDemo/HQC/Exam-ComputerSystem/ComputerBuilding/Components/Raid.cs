using System;
using System.Collections.Generic;
using System.Linq;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Components
{
    class Raid:IStorage
    {
      //  private int _capacity;

        public Raid(List<HardDrive> raidDrives)
        {
            
            HardDrives = new List<HardDrive>();
        }

        public int Capacity
        {

            get
            {
                if (!HardDrives.Any())
                {
                    return 0;
                }
                return this.HardDrives.FirstOrDefault().Capacity;
            }
           
        }

        public IList<HardDrive> HardDrives { get; private set; }

        public void SaveData(int address, string newData)
        {
            foreach (var hardDrive in HardDrives)
            {
                hardDrive.SaveData(address,newData);
            }
        }

        public string LoadData(int address)
        {
            if (!this.HardDrives.Any())
            {
                throw new OutOfMemoryException("No hard drive in the RAID array!");
            }
            return this.HardDrives.First().LoadData(address);
        }
    }
}
