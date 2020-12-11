namespace PizzaApi
{
    public class QuatroStagioniFactory : PizzaFactory
    {

        public override Pizza GetPizza()
        {
            var quatroStagioni = new Pizza
            {
                Ingredients = GetBaseIngredients(Pizzas.QuatroStagioni),
                Name = Pizzas.QuatroStagioni.ToString()
            };
            return quatroStagioni;
        }
    }
}
