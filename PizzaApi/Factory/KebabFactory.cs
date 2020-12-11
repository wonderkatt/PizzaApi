namespace PizzaApi
{
    public class KebabFactory : PizzaFactory
    {

        public override Pizza GetPizza()
        {
            var kebab = new Pizza
            {
                Ingredients = GetBaseIngredients(Pizzas.Kebab),
                Name = Pizzas.Kebab.ToString()
            };
            return kebab;
        }
    }
}
