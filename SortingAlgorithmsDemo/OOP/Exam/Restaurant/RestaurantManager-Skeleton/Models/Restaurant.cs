using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Restaurant:IRestaurant
    {
        private string _name;
        private string _location;

        public Restaurant(string name, string location)
        {
            Recipes = new List<IRecipe>();
            Location = location;
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value==string.Empty || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                _name = value;
            }
        }

        public string Location
        {
            get { return _location; }
            private set
            {
                if (value == string.Empty || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location cannot be null or empty!");
                }
                _location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            var sb = new StringBuilder();
            throw new System.NotImplementedException();
        }
    }
}
