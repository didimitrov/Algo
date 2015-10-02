using System;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Recipe:IRecipe
    {
        private string _name;
        private decimal _price;
        private int _calories;
        private int _quantityPerServing;
        private int _timeToPrepare;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            TimeToPrepare = timeToPrepare;
            Unit = unit;
            QuantityPerServing = quantityPerServing;
            Calories = calories;
            Price = price;
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                ValidateName(value,"Name");
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            private set
            {
                ValidateValues(value,"Price");
                _price = value;
            }
        }

        public virtual int Calories
        {
            get { return _calories; }
            protected set
            {
                ValidateValues(value,"Price");
                _calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return _quantityPerServing; }
            private set
            {
               ValidateValues(value,"QuantityPerServing");
                _quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; private set; }

        public virtual int TimeToPrepare
        {
            get { return _timeToPrepare; }
            protected set
            {
                ValidateValues(value,"TimeToPrepare");
                _timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("==  {0} == ${1:F2}", this.Name, this.Price));
            result.AppendLine(string.Format("Per serving: {0} {1}, {2} kcal",
                this.QuantityPerServing, this.Unit == MetricUnit.Grams ? "g" : "ml", this.Calories));
            result.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            return result.ToString();
        }

        private void ValidateName(string value, string e)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(string.Format("The {0} is required", e));
            }
        }

        private void ValidateValues(decimal value, string e)
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException(string.Format("The {0} must be positive", e));
            }
        }
    }
}
