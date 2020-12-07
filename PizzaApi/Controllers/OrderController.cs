using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetCart()
        {
            var cart = CartSingleton.Instance();
            return Ok(cart);
        }

    }
}
