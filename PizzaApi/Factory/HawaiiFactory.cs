using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class HawaiiFactory : PizzaFactory
    {
        public override Pizza GetPizza()
        {
            var hawaii = new Pizza
            {
                Ingredients = GetBaseIngredients(Pizzas.Hawaii),
                Name = Pizzas.Hawaii.ToString()
            };
            return hawaii;
        }
    }
}
