using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Sweetener:MenuItemAddition
    {
        public Sweetener(MenuItem item) : base(item)
        {
            
            Description += "Sweetener";
            BaseCost += 0.05m;
        }
    }
}
