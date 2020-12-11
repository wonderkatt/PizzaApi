using System;

namespace PizzaApi
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string id) : base($"No item with id: {id} was found.")
        {
        }
    }
}
