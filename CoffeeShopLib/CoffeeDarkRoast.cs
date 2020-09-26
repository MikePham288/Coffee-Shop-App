using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class CoffeeDarkRoast : MenuItem
    {
        public CoffeeDarkRoast()
        {
            Description = "Dark roast coffee";
            BaseCost = 2;
        }
    }
}
