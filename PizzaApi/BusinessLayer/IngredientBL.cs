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
                switch (id)
                {
                    case (int) ExtraIngredients.Ham:
                        ingredients.Add(_ingredientFactory.GetHam());
                        break;
                    case (int) ExtraIngredients.Pineapple:
                        ingredients.Add(_ingredientFactory.GetPineapple());
                        break;
                    case (int) ExtraIngredients.Mushrooms:
                        ingredients.Add(_ingredientFactory.GetMushrooms());
                        break;
                    case (int) ExtraIngredients.Onion:
                        ingredients.Add(_ingredientFactory.GetOnion());
                        break;
                    case (int) ExtraIngredients.KebabSauce:
                        ingredients.Add(_ingredientFactory.GetKebabSauce());
                        break;
                    case (int) ExtraIngredients.Shrimp:
                        ingredients.Add(_ingredientFactory.GetShrimp());
                        break;
                    case (int) ExtraIngredients.Clam:
                        ingredients.Add(_ingredientFactory.GetClam());
                        break;
                    case (int) ExtraIngredients.Artichoke:
                        ingredients.Add(_ingredientFactory.GetArtichoke());
                        break;
                    case (int) ExtraIngredients.Kebab:
                        ingredients.Add(_ingredientFactory.GetKebab());
                        break;
                    case (int) ExtraIngredients.Cilantro:
                        ingredients.Add(_ingredientFactory.GetCilantro());
                        break;
                    default:
                        throw new ItemNotFoundException("ingredient " + id);
                }
            }

            return ingredients;
        }
    }
}
