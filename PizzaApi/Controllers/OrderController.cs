using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private PizzaBL _pizzaBL;

        public OrderController()
        {
            _pizzaBL = new PizzaBL();
        }
        [HttpGet]
        public ActionResult GetCurrentOrder()
        {
            var cart = CartSingleton.Instance();
            if (cart.Order.IsEmpty)
            {
                return Ok("Your cart is empty");
            }
            return Ok(cart.Order);
        }
        [HttpPost]
        public ActionResult AddItemsToOrder([FromBody]AddToOrderRequest request)
        {
            var cart = CartSingleton.Instance();

            try
            {
                var pizzasToAdd = new List<Pizza>();
                foreach (var pizza in request.Pizzas)
                { 
                    pizzasToAdd.Add(_pizzaBL.CreatePizza(pizza));
                }
                cart.Order.Pizzas.AddRange(pizzasToAdd);
            }
            catch (ItemNotFoundException e)
            {
                return BadRequest(e.Message);
            }

            return Ok();

        }
    }
}
