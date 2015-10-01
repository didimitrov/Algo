namespace Singleton
{
   public  class PrimeMinister
    {
        private static readonly PrimeMinister Instance = new PrimeMinister();

        static PrimeMinister()
        {
        }

        private PrimeMinister()
        {
        }

        public static PrimeMinister GetInstanse
        {
            get { return Instance; }
        }
    }
}
