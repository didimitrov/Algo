using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    class Spell:ISpell
    {
        public Spell(int damage, int energyCost)
        {
            EnergyCost = energyCost;
            Damage = damage;
        }

        public int Damage { get; private set; }
        public int EnergyCost { get; private set; }
    }
}
