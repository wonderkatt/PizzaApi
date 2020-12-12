using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class OrderBL
    {

        public void SetTotalPrice(Order order)
        {
            order.TotalPrice = 0;

            foreach (var drink in order.Drinks)
            {
                order.TotalPrice += drink.Value.Price;
            }
            foreach (var pizza in order.Pizzas)
            {
                order.TotalPrice += pizza.Value.Price;
            }
       
        }
    }
}
