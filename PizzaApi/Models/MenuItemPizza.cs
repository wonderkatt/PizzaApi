using System.Collections.Generic;

namespace PizzaApi
{
    public class MenuItemPizza : IPurchasable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public int Price { get;}

    }
}
