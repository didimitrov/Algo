using System;
using System.Security.Cryptography;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Drink:Recipe, IDrink
    {
       
        private const int MaxCalories = 100;
        private const int MaxTimeToPrepare = 20;

        public Drink(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            IsCarbonated = isCarbonated;
        }

        public override int Calories
        {
            get
            {
                return base.Calories;
            }

            protected set
            {
                if (value > MaxCalories)
                {
                    throw new ArgumentException(string.Format("The calories in a drink must not be greater than {0}.", MaxCalories));
                }

                base.Calories = value;
            }
        }

        public override int TimeToPrepare {
            get
            {
                return base.Calories;
            }
            protected set
            {
                if (value>MaxTimeToPrepare)
                {
                    throw new ArgumentException(string.Format("The time to prepare a drink must not be greater than {0}.", MaxTimeToPrepare));
                }
                base.TimeToPrepare = value;
            }
            
        }
        public bool IsCarbonated { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
