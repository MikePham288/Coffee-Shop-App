using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{

    public class OrderItem
    {
        /*
         * Author: Le Minh Pham
         * Student Number: 300814556
         */
        private IMenuItem item;
        public OrderItem()
        {
            item = null;
        }
        public OrderItem(IMenuItem menuItem)
        {
            Item = menuItem;
        }
        [JsonProperty]
        public IMenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
        public override string ToString()
        {
            string result;
            result = $"{item.Description} - {item.BaseCost:c}";
            return result;
        }
        public decimal CalCost()
        {
            return item.BaseCost;
        }
    }
}
