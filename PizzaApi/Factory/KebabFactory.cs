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
            kebab.Name = Pizzas.Kebab.ToString();
            return kebab;
        }

        public override List<Ingredient> GetBaseIngredients()
        {
            var ingredients = base.GetBaseIngredients();
            ingredients.AddRange(new List<Ingredient>
            { 
                IngredientFactory.GetKebab(), 
                IngredientFactory.GetMushrooms(),
                IngredientFactory.GetOnion(),
                IngredientFactory.GetPeperoncino(),
                IngredientFactory.GetLettuce(),
                IngredientFactory.GetTomato(),
                IngredientFactory.GetKebabSauce()
            });

            return ingredients;
        }

    }
}
