using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Salad:Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool containsPasta) 
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            this.IsVegan = true;
            ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.AppendFormat("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no");
            return result.ToString();
        }
    }
}
