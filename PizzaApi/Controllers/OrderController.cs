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
        [Route("{id}")]
        [HttpPost]
        public ActionResult SaveOrder(int id)
        {

            var cart = CartSingleton.Instance();
            cart.Order.Status = Status.InProgress;
            cart.Order.OrderTime = DateTime.Now;

            return Ok();

        }
    }
}
