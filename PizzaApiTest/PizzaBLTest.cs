using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaApi;

namespace PizzaApiTest
{
    [TestClass]
    public class PizzaBLTest
    {
        [TestMethod]
        public void CreatePizzaFromId_ShouldCreateMargarita()
        {
            var pizzaBL = new PizzaBL();
            var id = 1;
            var expected = "Margerita";
            var pizza = pizzaBL.CreatePizzaFromId(id);

            Assert.AreEqual(expected, pizza.Name);
        }
        [TestMethod]
        public void CreatePizza_ShouldCreateMargaritaWithMushrooms()
        {
            var margeritaFactory = new MargeritaFactory();
            var ingredientFactory = new IngredientFactory();
            var pizzaBL = new PizzaBL();
            var pizzaDTO = new PizzaDTO
            {
                Id = 1,
                ExtraIngredients = new List<int>
                {
                    (int)ExtraIngredients.Mushrooms
                }
            };
            var expected = margeritaFactory.GetPizza();
            expected.ExtraIngredients.Add(ingredientFactory.GetMushrooms());

            var pizza = pizzaBL.CreatePizza(pizzaDTO);

            Assert.AreEqual(expected.Name, pizza.Name);
            Assert.AreEqual(expected.ExtraIngredients[0].Name, pizza.ExtraIngredients[0].Name);
        }
    }
}
