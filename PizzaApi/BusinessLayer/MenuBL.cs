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
        public Menu GetMenu()
        {
            var menu = ComposeMenu();
            
            return menu;
        }
        private Menu ComposeMenu()
        {
            var menu = new Menu
            {
                Pizzas = GetPizzasOnMenu(),
                Drinks = GetDrinksOnMenu(),
                ExtraIngredients = GetExtraIngredientsOnMenu()
            };
            return menu;
        }
        private List<Pizza> GetPizzasOnMenu()
        {
            return new List<Pizza>();
        }
        private List<Drink> GetDrinksOnMenu()
        {
            return new List<Drink>();
        }
        private List<Ingredient> GetExtraIngredientsOnMenu()
        {
            throw new NotImplementedException();
        }
    }
}
