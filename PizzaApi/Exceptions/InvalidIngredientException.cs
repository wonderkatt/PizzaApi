using System;

namespace PizzaApi
{
    public class InvalidIngredientException : Exception
    {
        public InvalidIngredientException(string ingredient) : base($"No valid ingredients was found named {ingredient}.")
        {
        }
    }
}
