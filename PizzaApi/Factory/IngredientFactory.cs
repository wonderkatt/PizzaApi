using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public  class IngredientFactory
    {
        public  Ingredient GetKebab()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 20;
            ingredient.Name = "Kebab";
            return ingredient;
        }

        public Ingredient GetHam()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Ham";
            return ingredient;
        }

        public Ingredient GetPineapple()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Pineapple";
            return ingredient;
        }

        public Ingredient GetArtichoke()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 15;
            ingredient.Name = "Artichoke";
            return ingredient;
        }

        public Ingredient GetCilantro()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 20;
            ingredient.Name = "Cilantro";
            return ingredient;
        }

        public Ingredient GetClam()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 15;
            ingredient.Name = "Clam";
            return ingredient;
        }

        public Ingredient GetShrimp()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 15;
            ingredient.Name = "Shrimp";
            return ingredient;
        }

        public Ingredient GetLettuce()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 0;
            ingredient.Name = "Lettuce";
            return ingredient;
        }

        public Ingredient GetKebabSauce()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Kebab Sauce";
            return ingredient;
        }

        public Ingredient GetTomato()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 0;
            ingredient.Name = "Tomato";
            return ingredient;
        }

        public Ingredient GetPeperoncino()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 0;
            ingredient.Name = "Peperoncino";
            return ingredient;
        }

        public Ingredient GetOnion()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Onion";
            return ingredient;
        }

        public Ingredient GetMushrooms()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Mushrooms";
            return ingredient;
        }

        public Ingredient GetCheese()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Cheese";
            return ingredient;
        }

        public Ingredient GetTomatoSauce()
        {
            var ingredient = new Ingredient();
            ingredient.Cost = 10;
            ingredient.Name = "Tomato Sauce";
            return ingredient;
        }

    }
}
