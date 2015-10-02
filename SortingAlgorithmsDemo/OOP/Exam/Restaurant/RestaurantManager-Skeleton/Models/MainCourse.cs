using System;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class MainCourse:Meal,IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, MainCourseType type) : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type.ToString()); ;
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            ////Type: Soup
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Type: {0}", this.Type).AppendLine();
            return sb.ToString();
        }
    }
}
