namespace WinterIsComing.Models.Spells
{
    class Stomp:Spell
    {
        private const int DefaultEnergyConst = 10;

        public Stomp(int damage) : base(damage, DefaultEnergyConst)
        {
        }
    }
}
