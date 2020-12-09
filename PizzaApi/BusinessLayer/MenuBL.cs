using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PizzaApi
{
    public class MenuBL
    {

        private readonly PizzaBL _pizzaBL;
        private readonly DrinkBL _drinkBL;
        private readonly IngredientBL _ingredientBL;

        public MenuBL()
        {
            _pizzaBL = new PizzaBL();
            _drinkBL = new DrinkBL();
            _ingredientBL = new IngredientBL();
        }
        public Menu GetMenu()
        {
            var menu = ComposeMenu();
            
            return menu;
        }
        private Menu ComposeMenu()
        {
            var pizzaList = _pizzaBL.GetAllPizzasOnMenu();
            var drinkList = _drinkBL.GetAllDrinksOnMenu();
            var ingredientList = _ingredientBL.GetAllExtraIngredientsOnMenu();
            var menu = new Menu
            {
                Pizzas = ConvertListToDictionary(pizzaList),
                Drinks = ConvertListToDictionary(drinkList),
                ExtraIngredients = ConvertListToDictionary(ingredientList)
            };
            return menu;
        }

        private Dictionary<int, T> ConvertListToDictionary<T>(List<T> list)
        {
            var dictionary = new Dictionary<int, T>();
            for (var i = 0; i < list.Count; i++)
            {
                dictionary.Add(i + 1,list[i]);
            }

            return dictionary;
        }
    }
}
