using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Cheese:MenuItemAddition
    {
        public Cheese(MenuItem item) : base(item)
        {
			
            BaseCost += 0.4m;
            Description += "Cheese";
        }
    }
}
