using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class MenuDAL
    {
        //..\PizzaApi\Files\menu.json
        private const string MENU_PATH = @"E:\repos\PizzaApi\PizzaApiTest\menu.json";
        public string ReadMenuFromFile()
        {
            var menu = File.ReadAllText(MENU_PATH);

            return menu;
        }

        public List<string> GetIngredientsFromMenuForPizza(Pizzas pizzaType)
        {
            var menu = ReadMenuFromFile();
            var deserializedMenu = JsonSerializer.Deserialize<Menu>(menu);

            foreach (var pizza in deserializedMenu.Pizzas)
            {
                if (pizzaType.ToString() == StringFormater.RemoveSpacesFromString(pizza.Name))
                {
                    return pizza.Ingredients;
                }
            }
            throw new NoIngredientsFoundException(pizzaType.ToString());
        }
    }
}
