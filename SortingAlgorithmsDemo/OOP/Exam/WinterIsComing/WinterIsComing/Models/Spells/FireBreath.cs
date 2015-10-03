namespace WinterIsComing.Models.Spells
{
    class FireBreath:Spell
    {
        private const int DefaultEnergyConst = 30;
        public FireBreath(int damage)
            : base(damage, DefaultEnergyConst)
        {
        }
    }
}
