using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class IceGiant:Unit
    {
        private const int DefaultHealthPoints = 300;
        private const int DefaultAttackPoints = 150;
        private const int DefaultDefensePoints = 60;
        private const int DefaultEnergyPoints = 50;
        private const int DefaultRange = 1;


        public IceGiant(string name, int range, int x, int y, int attackPoints, int healthPoints, int defensePoints, int energyPoints) :
            base(name, DefaultRange, x, y, DefaultAttackPoints, DefaultHealthPoints, DefaultDefensePoints, DefaultEnergyPoints)
        {
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
    }
}
