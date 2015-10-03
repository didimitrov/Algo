using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class Warrior : Unit
    {
        private const int DefaultAttPoints = 120;
        private const int DefaultHealthtPoints = 180;
        private const int DefaultRange = 1;
        private const int DefaultEnergy = 120;
        private const int DefaultDefense = 120;

        public Warrior(string name, int x, int y)
            : base(name, DefaultRange,x, y, DefaultAttPoints, DefaultHealthtPoints, DefaultDefense, DefaultEnergy)
        {
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
   
}
