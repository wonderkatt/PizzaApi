namespace PizzaApi
{
    public class Drink : IPurchasable, IVisitable
    {
        public string Name { get; }
        public int Price { get; }

        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}