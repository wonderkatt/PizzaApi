using System.Collections.Generic;

namespace PizzaApi
{
    public class OrderStoreSingleton
    {
        private static OrderStoreSingleton _orderStore;
        public Dictionary<int, Order> Orders;

        private OrderStoreSingleton()
        {
            Orders = new Dictionary<int, Order>();
        }

        public static OrderStoreSingleton Instance()
        {
            if (_orderStore == null)
            {
                _orderStore = new OrderStoreSingleton();
            }
            return _orderStore;
        }
    }
}
