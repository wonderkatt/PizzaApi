using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class CartSingleton
    {
        private static CartSingleton cart;
        public Order Order;

        private CartSingleton()
        {
            Order = new Order();
        }

        public static CartSingleton Instance()
        {
            if(cart == null)
            {
                cart = new CartSingleton();
            }
            return cart;
        }
    }
}
