﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class ModifyPizzaDTO
    {
        public int Id { get; set; }
        public List<int> Ingredients { get; set; }
    }
}
