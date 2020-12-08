using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public abstract class PizzaFactory 
    {
        protected IngredientFactory IngredientFactory;

        protected PizzaFactory()
        {
            IngredientFactory = new IngredientFactory();
        }
        public virtual List<Ingredient> GetBaseIngredients()
        {
            return new List<Ingredient>
            {
                IngredientFactory.GetCheese(),
                IngredientFactory.GetTomatoSauce()
            };
        }
        public abstract Pizza GetPizza();
    }
}
