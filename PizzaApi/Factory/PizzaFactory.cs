using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaApi
{
    public abstract class PizzaFactory 
    {
        
        private readonly MenuDAL _menuDAL;
        private readonly IngredientBL _ingredientBL;

        protected PizzaFactory()
        {
            _ingredientBL = new IngredientBL();
            _menuDAL = new MenuDAL();
        }

        public virtual List<Ingredient> GetBaseIngredients(Pizzas pizzaType)
        {
            var ingredients = _menuDAL.GetIngredientsFromMenuForPizza(pizzaType);
            var baseIngredients = new List<Ingredient>();
            foreach (var ingredient in ingredients)
            {
                baseIngredients.Add(_ingredientBL.CreateIngredientFromString(ingredient));
            }
            return baseIngredients;
        } 

        public abstract Pizza GetPizza();
    }
}
