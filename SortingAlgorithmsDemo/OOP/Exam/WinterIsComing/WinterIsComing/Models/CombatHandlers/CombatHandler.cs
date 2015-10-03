using System.Collections.Generic;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.CombatHandlers
{
    abstract class CombatHandler:ICombatHandler
    {
        protected CombatHandler(IUnit unit)
        {
            Unit = unit;
        }

        public  IUnit Unit { get; set; }

        public abstract IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets);

        public abstract ISpell GenerateAttack();

    }
}
