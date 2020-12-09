using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApi
{
    public class Order
    {
        public bool IsEmpty => !Pizzas.Any() && !Drinks.Any();
        public List<Pizza> Pizzas { get; set; }
        public List<Drink> Drinks { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public Status Status;

        public Order()
        {
            Pizzas = new List<Pizza>();
            Drinks = new List<Drink>();
        }
    }
}