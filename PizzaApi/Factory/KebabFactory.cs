using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class KebabFactory : PizzaFactory
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
                ingredientFactory.GetKebab(), 
                ingredientFactory.GetMushrooms(),
                ingredientFactory.GetOnion(),
                ingredientFactory.GetPeperoncino(),
                ingredientFactory.GetLettuce(),
                ingredientFactory.GetTomato(),
                ingredientFactory.GetKebabSauce()
            });

            return ingredients;
        }

    }
}
