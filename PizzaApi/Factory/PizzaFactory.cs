using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public abstract class PizzaFactory 
    {
        protected IngredientFactory ingredientFactory;
        public PizzaFactory()
        {
            ingredientFactory = new IngredientFactory();
        }

        public virtual List<Ingredient> GetBaseIngredients()
        {
            return new List<Ingredient>
            {
                ingredientFactory.GetCheese(),
                ingredientFactory.GetTomatoSauce()
            };
        }

        public abstract Pizza GetPizza();
    }
}
