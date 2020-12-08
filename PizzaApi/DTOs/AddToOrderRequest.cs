using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class AddToOrderRequest
    {
        public List<PizzaDTO> Pizzas { get; set; }
        public List<int> Drinks { get; set; }
    }

}
