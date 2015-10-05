using System.Collections.Generic;
using Observer.Interfaces;
using Observer.Items;

namespace Observer.Units
{
    public class Dragon : Unit
    {
        private IList<Warrior> _observers;


        public Dragon(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            this.Observers = new List<Warrior>();
        }

        public override int HealthPoints
        {
            get { return base.HealthPoints; }
            set
            {
                if (this.HealthPoints!=value)
                {
                    Notify();
                  
                }
                base.HealthPoints -= value;
            }
        }

        public IList<Warrior> Observers
        {
            get { return _observers; }
            set { _observers = value; }
        }

        public void Attach(Warrior observer)
        {
            this.Observers.Add(observer);
        }

        public void Detach(Warrior observer)
        {
            this.Observers.Remove(observer);
        }

        private void Notify()
        {
            if (this.HealthPoints<=0)
            {
                foreach (var observer in Observers)
                {
                    observer.Update(new Weapon(100, 100));
                }
            }
        }
    }
}
