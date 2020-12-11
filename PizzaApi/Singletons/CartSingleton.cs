namespace PizzaApi
{
    public class CartSingleton
    {
        private static CartSingleton _cart;
        public Order Order;

        private CartSingleton()
        {
            Order = new Order();
        }

        public static CartSingleton Instance()
        {
            if(_cart == null)
            {
                _cart = new CartSingleton();
            }
            return _cart;
        }
    }
}
