using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class DrinkBL
    {
        private const int Price20 = 20;
        private const int Price25 = 25;

        public Drink CreateDrink(int drinkId)
        {
            return drinkId switch
            {
                (int) Drinks.Coke => new Drink(Drinks.Coke.ToString(), Price20),
                (int) Drinks.Fanta => new Drink(Drinks.Fanta.ToString(), Price20),
                (int) Drinks.Sprite => new Drink(Drinks.Sprite.ToString(), Price25),
                _ => throw new ItemNotFoundException(drinkId.ToString())
            };
        }

        public List<Drink> GetAllDrinksOnMenu()
        {
            return new List<Drink>
            {
                new Drink(Drinks.Coke.ToString(), Price20),
                new Drink(Drinks.Fanta.ToString(), Price20),
                new Drink(Drinks.Sprite.ToString(), Price25)
            };
        }
    }
}
