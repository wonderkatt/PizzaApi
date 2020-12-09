using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class Menu
    {
        public Dictionary<int,Pizza> Pizzas{ get; set; }
        public Dictionary<int, Drink> Drinks { get; set; }
        public Dictionary<int, Ingredient> ExtraIngredients { get; set; }

    }
}
