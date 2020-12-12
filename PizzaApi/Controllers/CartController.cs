using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartSingleton _cart;
        private readonly PizzaBL _pizzaBL;
        private readonly DrinkBL _drinkBL;
        private readonly IngredientBL _ingredientBL;
        private readonly OrderBL _orderBL;
        private readonly CartBL _cartBL;

        public CartController(CartSingleton cart, CartBL cartBL, PizzaBL pizzaBL, DrinkBL drinkBL, OrderBL orderBL, IngredientBL ingredientBL)
        {
            _cart = cart;
            _cartBL = cartBL;
            _pizzaBL = pizzaBL;
            _drinkBL = drinkBL;
            _ingredientBL = ingredientBL;
            _orderBL = orderBL;
        }

        [HttpGet]
        public ActionResult GetCartContents()
        {
            return _cart.Order.IsEmpty ? Ok("Your cart is empty") : Ok(_cart.Order);
        }
        [HttpPost]
        public ActionResult AddItemsToCart([FromBody] AddToOrderRequest request)
        {
            var pizzasToAdd = new List<Pizza>();
            var drinksToAdd = new List<Drink>();
            try
            {
                foreach (var pizza in request.Pizzas)
                {
                    pizzasToAdd.Add(_pizzaBL.CreatePizza(pizza));
                }
                foreach (var drink in request.Drinks)
                {
                    drinksToAdd.Add(_drinkBL.CreateDrink(drink));
                }
            }
            catch (ItemNotFoundException e)
            {
                return BadRequest(e.Message);
            }
            _cartBL.StoreCollectionInCart(pizzasToAdd, drinksToAdd);
            _orderBL.SetTotalPrice(_cart.Order);
            return Ok();
        }

        [HttpPatch]
        public ActionResult UpdatePizzasInCart([FromBody] ModifyOrderRequest request)
        {
            try
            {
                foreach (var orderItem in request.Pizzas)
                {
                    _cart.Order.Pizzas[orderItem.Id].ExtraIngredients =
                        _ingredientBL.GetIngredients(orderItem.Ingredients);
                }
            }
            catch (ItemNotFoundException e)
            {
                return BadRequest(e.Message);
            }
            _orderBL.SetTotalPrice(_cart.Order);
            return Ok();

        }
        [HttpDelete]
        public ActionResult RemoveItemsInCart([FromBody] RemoveItemsRequest request)
        {
            foreach (var id in request.PizzaIds.Where(id => _cart.Order.Pizzas.ContainsKey(id)))
            {
                _cart.Order.Pizzas.Remove(id);
            }
            foreach (var id in request.DrinkIds.Where(id => _cart.Order.Drinks.ContainsKey(id)))
            {
                _cart.Order.Drinks.Remove(id);
            }
            _orderBL.SetTotalPrice(_cart.Order);
            return NoContent();
        }
    

    }




}
