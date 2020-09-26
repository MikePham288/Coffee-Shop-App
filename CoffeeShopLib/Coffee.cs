using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Coffee:MenuItem
    {
        public Coffee()
        {
            Description = "Black Coffee";
            BaseCost = 2m;
        }
    }
}
