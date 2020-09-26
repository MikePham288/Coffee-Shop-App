using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class MenuItemAddition : MenuItem
    {


        public MenuItemAddition(MenuItem item)
        {
            Description += $"{item.Description}, ";
            BaseCost += item.BaseCost;

        }
		public override string ToString()
		{
            string result;
            result=$"Menu Item:\tDescription: {Description}\n\tBase Cost: {BaseCost:c}";
            return result;
        }

	}
}
