using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class CartBL
    {
        private readonly CartSingleton _cart;

        public CartBL(CartSingleton cart)
        {
            _cart = cart;
        }
        public void StoreCollectionInCart(IEnumerable<Pizza> pizzas, IEnumerable<Drink> drinks)
        {
            foreach (var pizza in pizzas)
            {
                _cart.Order.Pizzas.Add(_cart.Order.Pizzas.Count, pizza);
            }
            foreach (var drink in drinks)
            {
                _cart.Order.Drinks.Add(_cart.Order.Drinks.Count, drink);
            }
        }
    }
}
