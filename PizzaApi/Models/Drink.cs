namespace PizzaApi
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; }
        public int Price { get; }

        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}