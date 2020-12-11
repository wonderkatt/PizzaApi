using Microsoft.AspNetCore.Mvc;
using System;

namespace PizzaApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public ActionResult SaveCurrentOrder()
        {
            var cart = CartSingleton.Instance();
            var orderStore = OrderStoreSingleton.Instance();
            cart.Order.Status = Status.InProgress;
            cart.Order.OrderTime = DateTime.Now;
            orderStore.Orders.Add(orderStore.Orders.Count, cart.Order);
            cart.Order = new Order();

            return Ok();

        }
    }
}
