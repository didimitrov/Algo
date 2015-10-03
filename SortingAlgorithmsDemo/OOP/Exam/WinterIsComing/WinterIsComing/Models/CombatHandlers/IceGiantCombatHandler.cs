using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class IceGiantCombatHandler:CombatHandler
    {
        public IceGiantCombatHandler(IUnit unit) : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (Unit.HealthPoints<=150)
            {
                return candidateTargets.Take(1);
            }
            return candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            ISpell spell = new Stomp(this.Unit.AttackPoints);

            if (spell.EnergyCost > this.Unit.EnergyPoints)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", this.Unit.Name, spell.GetType().Name));
            }

            this.Unit.EnergyPoints -= spell.EnergyCost;
            this.Unit.AttackPoints += 5;
            return spell;
        }
    }
}
