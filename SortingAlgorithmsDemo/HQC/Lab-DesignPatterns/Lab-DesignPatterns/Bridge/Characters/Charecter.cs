using Bridge.Weapons;

namespace Bridge.Characters
{
    public abstract class Charecter
    {
        private Weapon _weapon;

        protected Charecter(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
    }
}
