using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console.Components
{
   public class Battery : IRechargable
    {
        private int _currentCharge;

        public const byte MaxCharge = 100;
        public const byte MinCharge = 0;

        public Battery()
        {
            this.CurrentCharge = MaxCharge/2;
        }

        public int CurrentCharge
        {
            get { return _currentCharge; }
            set
            {
                if (value>MaxCharge)
                {
                    value = MaxCharge;
                }
                if (value<MinCharge)
                {
                    value = MinCharge;
                }
                _currentCharge = value;
            }
        }

        public void Charge(int p)
        {
            this.CurrentCharge += p;
        }
    }
}
