using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class HawaiiFactory : PizzaFactory
    {
        public override Pizza GetPizza()
        {
            var hawaii = new Pizza();
            hawaii.Ingredients = GetBaseIngredients();
            hawaii.Name = Pizzas.Hawaii.ToString();
            return hawaii;
        }

        public override List<Ingredient> GetBaseIngredients()
        {
            var ingredients = base.GetBaseIngredients();
            ingredients.AddRange(new List<Ingredient>
            { 
                IngredientFactory.GetPineapple(), 
                IngredientFactory.GetHam() 
            });

            return ingredients;
        }

    }
}
