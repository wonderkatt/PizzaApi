using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult GetCartContents()
        {
            var cart = CartSingleton.Instance();
            return cart.Order.IsEmpty ? Ok("Your cart is empty") : Ok(cart.Order);
        }
        [HttpPost]
        public ActionResult AddItemsToCart([FromBody] AddToOrderRequest request)
        {
            var cart = CartSingleton.Instance();

            try
            {
                var pizzasToAdd = new List<Pizza>();
                foreach (var pizza in request.Pizzas)
                {
                    pizzasToAdd.Add(_pizzaBL.CreatePizza(pizza));
                }
                var drinksToAdd = new List<Drink>();
                foreach (var drink in request.Drinks)
                {
                    drinksToAdd.Add(_drinkBL.CreateDrink(drink));
                }
                cart.Order.Pizzas.AddRange(pizzasToAdd);
                cart.Order.Drinks.AddRange(drinksToAdd);
            }
            catch (ItemNotFoundException e)
            {
                return BadRequest(e.Message);
            }
            catch(NoIngredientsFoundException e)
            {
                return BadRequest(e.Message);
            }
            catch(InvalidIngredientException e)
            {
                return BadRequest(e.Message);
            }

            return Ok();

        }
    }
}
