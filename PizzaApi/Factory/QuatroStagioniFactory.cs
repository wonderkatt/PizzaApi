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
            var quatroStagioni = new Pizza();
            quatroStagioni.Ingredients = GetBaseIngredients();
            quatroStagioni.Name = Pizzas.QuatroStagioni.ToString();
            return quatroStagioni;
        }

        public override List<Ingredient> GetBaseIngredients()
        {
            var ingredients = base.GetBaseIngredients();
            ingredients.AddRange(new List<Ingredient>
            { 
                IngredientFactory.GetHam(), 
                IngredientFactory.GetShrimp(),
                IngredientFactory.GetClam(),
                IngredientFactory.GetMushrooms(),
                IngredientFactory.GetArtichoke()
            });

            return ingredients;
        }

    }
}
