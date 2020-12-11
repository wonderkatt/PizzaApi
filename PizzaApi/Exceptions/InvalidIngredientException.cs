using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class InvalidIngredientException : Exception
    {
        public InvalidIngredientException(string ingredient) : base($"No valid ingredients was found named {ingredient}.")
        {
        }
    }
}
