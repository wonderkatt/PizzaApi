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

        private IngredientFactory _ingredientFactory;
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
            var menu = new Menu
            {
                Pizzas = _pizzaBL.GetAllPizzasOnMenu(),
                Drinks = _drinkBL.GetAllDrinksOnMenu(),
                ExtraIngredients = _ingredientBL.GetAllExtraIngredientsOnMenu()
            };
            return menu;
        }
    }
}
