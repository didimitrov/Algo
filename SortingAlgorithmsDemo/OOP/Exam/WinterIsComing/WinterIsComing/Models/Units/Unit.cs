using System;
using System.Text;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Units
{
    class Unit:IUnit
    {
        private string _name;
        private int _range;

        public Unit(string name, int range, int x, int y, int attackPoints, int healthPoints, int defensePoints, int energyPoints)
        {
            EnergyPoints = energyPoints;
            DefensePoints = defensePoints;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
            Y = y;
            X = x;
          
            Range = range;
            Name = name;
        }

        public int X { get;  set; }
        public int Y { get; set; }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                _name = value;
            }
        }

        public int Range
        {
            get { return _range; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Range cannot be negative");
                }
                _range = value;
            }
        }

        public int AttackPoints { get; set; }
        public int HealthPoints { get; set; }
        public int DefensePoints { get;  set; }
        public int EnergyPoints { get;  set; }
        public ICombatHandler CombatHandler { get; protected set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(">{0} - {1} at ({2},{3})", this.Name, this.GetType().Name, this.X, this.Y)
                .AppendLine();
            if (this.HealthPoints > 0)
            {
                sb.AppendFormat("-Health points = {0}", this.HealthPoints)
                    .AppendLine()
                    .AppendFormat("-Attack points = {0}", this.AttackPoints)
                    .AppendLine()
                    .AppendFormat("-Defense points = {0}", this.DefensePoints)
                    .AppendLine()
                    .AppendFormat("-Energy points = {0}", this.EnergyPoints)
                    .AppendLine()
                    .AppendFormat("-Range = {0}", this.Range);
            }
            else
            {
                sb.Append("(Dead)");
            }

            return sb.ToString().TrimEnd('\n');
        }
    }
}
