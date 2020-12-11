using System.Collections.Generic;

namespace PizzaApi
{
    public class Pizza : IPurchasable
    {
        public string Name { get; set; }
        public int Price { get; }

        public List<Ingredient> Ingredients { get; set; }
        public List<Ingredient> ExtraIngredients { get; set; }
        public Pizza()
        {
            ExtraIngredients = new List<Ingredient>();
        }

    }
}