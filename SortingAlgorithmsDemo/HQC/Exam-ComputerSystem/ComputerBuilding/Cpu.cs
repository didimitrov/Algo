using System;
using System.Globalization;
using Computers.UI.Console.Interfaces;


namespace Computers.UI.Console
{
    class Cpu:ICpu
    {
        public static readonly Random Random = new Random();

        private IRam _ram;
        private IVideoCard _videoCard;
        private CpuArchitecture _architecture;

        public Cpu(IRam ram, IVideoCard videoCard, byte numberOfCores, CpuArchitecture architecture)
        {
            this.Ram = ram;
            this._videoCard = videoCard;
            NumberOfCores = numberOfCores;
            this.Architecture = architecture;
        }

       public byte NumberOfCores { get;  set; }

        public CpuArchitecture Architecture
        {
            get { return _architecture; }
            set { _architecture = value; }
        }

        public IRam Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        public void SquareNumber()
       {
            if (this.Architecture==CpuArchitecture.Bit32)
            {
                CalculateSquareNumber(0, 500);
            }
            if (this.Architecture==CpuArchitecture.Bit64)
            {
                CalculateSquareNumber(0, 1000);
            }
            if (Architecture==CpuArchitecture.Bit128)
            {

                CalculateSquareNumber(0, 2000);
            }
       }

        private void CalculateSquareNumber(int minBound, int maxBound)
        {
            var data = _ram.LoadValue();

            if (data<minBound)
            {
                this._videoCard.DrawTextData("Number too low.");
            }
            if (data >maxBound)
            {
                this._videoCard.DrawTextData("Number too high.");
                
            }
            else
            {
                var value = data * data;
                this._videoCard.DrawTextData((string.Format("Square of {0} is {1}.", data, value)));
            }
        }



        public void GenerateRandom(int a, int b)
       {
           int randomNumber = Random.Next(a, b + 1);
           this.Ram.SaveValue(randomNumber);
       }
    }

   
}
