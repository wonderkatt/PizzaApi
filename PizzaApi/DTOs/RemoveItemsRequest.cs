using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class RemoveItemsRequest
    {
        public List<int> PizzaIds { get; set; }
        public List<int> DrinkIds { get; set; }

    }
}
