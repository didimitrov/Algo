using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Dessert:Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool withSugar)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            WithSugar = true;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            ////[NO SUGAR] [VEGAN] ==  Black Chocolate Cake == $2.32
            if (this.WithSugar)
            {
                return base.ToString();
            }

            var sb = new StringBuilder();
            sb.Append("[NO SUGAR] ");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
