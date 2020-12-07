using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class QuatroStagioniFactory : PizzaFactory
    {

        public override Pizza GetPizza()
        {
            var kebab = new Pizza();
            kebab.Ingredients = GetBaseIngredients();
            return kebab;
        }

        public override List<Ingredient> GetBaseIngredients()
        {
            var ingredients = base.GetBaseIngredients();
            ingredients.AddRange(new List<Ingredient>
            { 
                ingredientFactory.GetHam(), 
                ingredientFactory.GetShrimp(),
                ingredientFactory.GetClam(),
                ingredientFactory.GetMushrooms(),
                ingredientFactory.GetArtichoke()
            });

            return ingredients;
        }

    }
}
