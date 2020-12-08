using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class PizzaBL
    {
        private MargeritaFactory _margeritaFactory;
        private HawaiiFactory _hawaiiFactory;
        private KebabFactory _kebabFactory;
        private QuatroStagioniFactory _quatroStagioniFactory;
        private IngredientBL _ingredientBL;

        public PizzaBL()
        {
            _margeritaFactory = new MargeritaFactory();
            _hawaiiFactory = new HawaiiFactory();
            _kebabFactory = new KebabFactory();
            _quatroStagioniFactory = new QuatroStagioniFactory();
            _ingredientBL = new IngredientBL();
        }

        public Pizza CreatePizza(PizzaDTO pizzaDTO)
        {
            var pizza = CreatePizzaFromId(pizzaDTO.Id);
            if (pizzaDTO.ExtraIngredients.Any())
            {
                pizza.ExtraIngredients = _ingredientBL.GetIngredients(pizzaDTO.ExtraIngredients);
            }
            return pizza;
        }
        public Pizza CreatePizzaFromId(int id)
        {
            return id switch
            {
                (int) Pizzas.Margerita => _margeritaFactory.GetPizza(),
                (int) Pizzas.Hawaii => _hawaiiFactory.GetPizza(),
                (int) Pizzas.Kebab => _kebabFactory.GetPizza(),
                (int) Pizzas.QuatroStagioni => _quatroStagioniFactory.GetPizza(),
                _ => throw new ItemNotFoundException("Pizza "+id)
            };
        }
    }
}
