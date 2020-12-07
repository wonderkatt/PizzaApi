using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaApi;

namespace PizzaApiTest
{
    [TestClass]
    public class CartSingletonTest
    {
        [TestMethod]
        public void GetCart_ShouldReturnSameInstance()
        {
            var cartOne = CartSingleton.Instance();
            var cartTwo = CartSingleton.Instance();

            Assert.AreSame(cartTwo, cartOne);
        }
    }
}
