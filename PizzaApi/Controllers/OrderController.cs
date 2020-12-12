using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly CartSingleton _cart;
        private readonly OrderStoreSingleton _orderStore;

        public OrderController(CartSingleton cart, OrderStoreSingleton orderStore)
        {
            _cart = cart;
            _orderStore = orderStore;
        }
        [HttpGet]
        public ActionResult GetOrders()
        {
            var activeOrders = _orderStore.Orders
                .Where(order => order.Value.Status == Status.InProgress);

            return activeOrders.Any() == false 
                ? Ok("No orders in store at the moment") 
                : Ok(activeOrders);
        }
        [HttpPost]
        public ActionResult SaveCurrentOrder()
        {
            if (_cart.Order.IsEmpty)
            {
                return BadRequest("No items in cart");
            }
            var orderId = _orderStore.Orders.Count;
            _cart.Order.Status = Status.InProgress;
            _cart.Order.OrderTime = DateTime.Now;
            _orderStore.Orders.Add(orderId, _cart.Order);
            _cart.Order = new Order();
            
            return Ok("Contents in cart saved with order id: "+ orderId);

        }
        [HttpPatch]
        public ActionResult UpdateOrderStatus([FromBody]UpdateOrderStatusRequest request)
        {
            Order order = new Order();
            try
            {
                order = _orderStore.Orders[request.Id];
                if (order.Status != Status.InProgress)
                {
                    throw new OrderInactiveException(request.Id.ToString());
                }
            }
            catch (OrderInactiveException e)
            {
                
                NotFound($"The order with id _{e.Message}_ is no longer active");
                
            }
            catch (KeyNotFoundException)
            {
                NotFound("No order with that ID was found");
                throw;
            }

            order.Status = request.OrderSuccessful ? Status.Completed : Status.Cancelled;

            return Ok($"Order with id {request.Id} was updated to {order.Status}");
        }


    }
}
