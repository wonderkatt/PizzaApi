using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class UpdateOrderStatusRequest
    {
        public int Id { get; set; }
        public bool OrderSuccessful { get; set; }
    }
}
