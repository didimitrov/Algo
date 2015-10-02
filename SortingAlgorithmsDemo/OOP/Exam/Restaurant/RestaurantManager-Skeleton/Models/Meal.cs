using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Meal:IMeal
    {
        public Meal(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            TimeToPrepare = timeToPrepare;
            Unit = unit;
            QuantityPerServing = quantityPerServing;
            Calories = calories;
            Price = price;
            Name = name;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Calories { get; private set; }
        public int QuantityPerServing { get; private set; }
        public MetricUnit Unit { get; private set; }
        public int TimeToPrepare { get; private set; }
        public bool IsVegan { get; protected set; }

        public void ToggleVegan()
        {
            this.IsVegan = !IsVegan;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (IsVegan)
            {
                sb.Append("[VEGAN] ");
            }
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
