using System;
using System.Collections.Generic;

namespace PizzaApi
{
    public class Pizza
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Ingredient> ExtraIngredients { get; set; }
        public string Name { get; set; }
        public Pizza()
        {
            ExtraIngredients = new List<Ingredient>();
        }
    }
}