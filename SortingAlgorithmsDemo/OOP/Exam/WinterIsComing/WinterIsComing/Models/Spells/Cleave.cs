namespace WinterIsComing.Models.Spells
{
    class Cleave : Spell
    {
        private const int DefaultEnergyConst = 15;
        public Cleave(int damage)
            : base(damage, DefaultEnergyConst)
        {
        }
    }
}
