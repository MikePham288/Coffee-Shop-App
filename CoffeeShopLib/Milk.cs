using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Milk:MenuItemAddition
    {
        public Milk(MenuItem item) : base(item)
		{
			
            BaseCost += 0.1m;
            Description += "Milk";
		}

	}
}
