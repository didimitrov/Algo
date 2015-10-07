using System.Collections.Generic;
using Computers.UI.Console.Components;
using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Factory
{
    // Concrete Factory
    class HpFactory:IComputerFactory
    {
        public IDesktop CreateDesktop()
        {
            var videocard = new ColorfulVideoCard();
            var ram = new Ram(2);
            var cpu = new Cpu(ram, videocard ,4, CpuArchitecture.Bit32 );
            IStorage storage = new HardDrive(500);

            return new Desktop(cpu,ram,videocard,storage);
        }

        public ILaptop CreateLaptop()
        {
            var ram = new Ram(4);
            var vCard = new ColorfulVideoCard();
            var battery = new Battery();
            var cpu = new Cpu(ram, vCard, 2, CpuArchitecture.Bit32);
            var hd = new HardDrive(500);

            return new Laptop(cpu,ram,vCard,hd,battery);
        }

        public IServer CreateServer()
        {
            var ram = new Ram(32);
            var raidDrives = new List<HardDrive>()
            {
                new HardDrive(1000),
                new HardDrive(1000)
            };

            IVideoCard gpu = new MonochromVideoCard();
            var cpu = new Cpu(ram, gpu, 4, CpuArchitecture.Bit128);
            IStorage storage = new Raid(raidDrives);

            return new Server(cpu,ram,gpu,storage);
        }
    }
}

