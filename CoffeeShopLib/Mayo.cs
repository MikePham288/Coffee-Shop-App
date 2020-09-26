using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Mayo:MenuItemAddition
    {
        public Mayo(MenuItem item) : base(item)
        {
			
            BaseCost += 0.4m;
            Description += "Cheese";
        }
    }
}
