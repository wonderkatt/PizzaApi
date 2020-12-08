using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class Menu
    {
        public List<Pizza> Pizzas{ get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Ingredient> ExtraIngredients { get; set; }

    }
}
