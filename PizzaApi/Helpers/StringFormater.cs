using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApi
{
    public class StringFormater
    {
        public static string RemoveSpacesFromString(string value)
        {
            return value.Replace(" ", "");
        }

    }
}
