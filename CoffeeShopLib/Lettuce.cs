using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Lettuce:MenuItemAddition
    {
        public Lettuce(MenuItem item) : base(item)
        {
			
            BaseCost += 0.3m;
            Description += "Lettuce";
        }
    }
}
