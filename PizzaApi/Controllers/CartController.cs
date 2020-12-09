using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly PizzaBL _pizzaBL;
        private readonly DrinkBL _drinkBL;

        public CartController()
        {
            _pizzaBL = new PizzaBL();
            _drinkBL = new DrinkBL();
        }

        [HttpGet]
        public ActionResult GetCurrentOrder()
        {
            var cart = CartSingleton.Instance();
            return cart.Order.IsEmpty ? Ok("Your cart is empty") : Ok(cart.Order);
        }
        [HttpPost]
        public ActionResult AddItemsToOrder([FromBody] AddToOrderRequest request)
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
                var drinksToAdd = new List<Drink>();
                foreach (var drink in request.Drinks)
                {
                    drinksToAdd.Add(_drinkBL.CreateDrink(drink));
                }
                cart.Order.Drinks.AddRange(drinksToAdd);
            }
            catch (ItemNotFoundException e)
            {
                return BadRequest(e.Message);
            }

            return Ok();

        }
    }
}
