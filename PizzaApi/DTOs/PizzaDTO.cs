using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class PizzaDTO
    {
        public int Id { get; set; }
        public List<int> ExtraIngredients { get; set; }
    }
}
