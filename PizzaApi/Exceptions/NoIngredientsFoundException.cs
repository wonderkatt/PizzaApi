using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class NoIngredientsFoundException : Exception
    {
        public NoIngredientsFoundException(string pizza) : base($"No valid ingredients was found for pizza: {pizza}.")
        {
        }
    }
}
