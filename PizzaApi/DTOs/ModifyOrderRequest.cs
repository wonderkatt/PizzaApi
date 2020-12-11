using System.Collections.Generic;

namespace PizzaApi
{
    public class ModifyOrderRequest
    {
        public List<OrderItemDTO> Pizzas { get; set; }
    }


}
