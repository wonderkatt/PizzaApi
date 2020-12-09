using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class IngredientBL
    {
        private IngredientFactory _ingredientFactory;

        public IngredientBL()
        {
            _ingredientFactory = new IngredientFactory();
        }
        public List<Ingredient> GetIngredients(List<int> ingredientIDs)
        {
            var distinctIds = ingredientIDs.Distinct();
            return CreateIngredientsFromIds(distinctIds);
        }
        private List<Ingredient> CreateIngredientsFromIds(IEnumerable<int> ids)
        {
            var ingredients = new List<Ingredient>();
            foreach (var id in ids)
            {
                ingredients.Add(CreateIngredientFromId(id));
            }

            return ingredients;
        }

        public List<Ingredient> GetAllExtraIngredientsOnMenu()
        {
            var ingredientsOnMenu = new List<Ingredient>();
            foreach (int ingredientId in Enum.GetValues(typeof(ExtraIngredients)))
            {
                ingredientsOnMenu.Add(CreateIngredientFromId(ingredientId));
            }

            return ingredientsOnMenu;
        }

        private Ingredient CreateIngredientFromId(int id)
        {
            return id switch
            {
                (int) ExtraIngredients.Ham => _ingredientFactory.GetHam(),
                (int) ExtraIngredients.Pineapple => _ingredientFactory.GetPineapple(),
                (int) ExtraIngredients.Mushrooms => _ingredientFactory.GetMushrooms(),
                (int) ExtraIngredients.Onion => _ingredientFactory.GetOnion(),
                (int) ExtraIngredients.KebabSauce => _ingredientFactory.GetKebabSauce(),
                (int) ExtraIngredients.Shrimp => _ingredientFactory.GetShrimp(),
                (int) ExtraIngredients.Clam => _ingredientFactory.GetClam(),
                (int) ExtraIngredients.Artichoke => _ingredientFactory.GetArtichoke(),
                (int) ExtraIngredients.Kebab => _ingredientFactory.GetKebab(),
                (int) ExtraIngredients.Cilantro => _ingredientFactory.GetCilantro(),
                _ => throw new ItemNotFoundException("ingredient " + id)
            };
        }
    }
}
