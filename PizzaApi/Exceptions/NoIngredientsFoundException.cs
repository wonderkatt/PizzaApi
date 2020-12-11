using System;

namespace PizzaApi
{
    public class NoIngredientsFoundException : Exception
    {
        public NoIngredientsFoundException(string pizza) : base($"No valid ingredients was found for pizza: {pizza}.")
        {
        }
    }
}
