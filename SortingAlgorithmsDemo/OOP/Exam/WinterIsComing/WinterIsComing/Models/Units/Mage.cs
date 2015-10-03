using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class Mage:Unit
    {
        private const int DefaultAttackPoints = 80;
        private const int DefaultDefensePoints = 40;
        private const int DefaultEnergyPoints = 120;
        private const int DefaultHealthPoints = 80;
        private const int DefaultRange = 2;

        public Mage(string name,int x, int y)
            : base(name, DefaultRange, x, y, DefaultAttackPoints, DefaultHealthPoints, DefaultDefensePoints, DefaultEnergyPoints)
        {
            this.CombatHandler = new MageCombatHendler(this);
        }
    }
}
