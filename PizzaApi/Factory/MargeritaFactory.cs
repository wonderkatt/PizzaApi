﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class MargeritaFactory : PizzaFactory
    {
        public override Pizza GetPizza()
        {
            var margerita = new Pizza
            {
                Ingredients = GetBaseIngredients(Pizzas.Margerita),
                Name = Pizzas.Margerita.ToString()
            };
            return margerita;
        }

    }
}
