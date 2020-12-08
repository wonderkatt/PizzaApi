using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string id) : base($"No item with id: {id} was found.")
        {
        }
    }
}
