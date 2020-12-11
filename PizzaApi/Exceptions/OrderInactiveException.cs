using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class OrderInactiveException :Exception
    {
        public OrderInactiveException(string message) :base(message)
        {
            
        }
    }
}
