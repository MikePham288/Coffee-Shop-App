using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Sugar:MenuItemAddition
    {


        public Sugar(MenuItem item) : base(item)
        {
            
            Description += "Sugar";
            BaseCost += 0.05m;
        }


    }
}
