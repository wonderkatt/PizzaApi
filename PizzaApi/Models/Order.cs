using System;
using System.Collections.Generic;

namespace PizzaApi
{
    public class Order
    {

        public List<Pizza> Pizzas { get; set; }
        public List<Drink> Drinks { get; set; }
        public int Cost { get; set; }
        public DateTime OrderTime { get; set; }
        public Status status;

        public Order()
        {

        }
    }
}