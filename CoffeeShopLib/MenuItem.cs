using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{

    public class MenuItem:IMenuItem
    {
        /*
         * Author: Le Minh Pham
         * Student Number: 300814556
         */
        [JsonProperty]
        private string description;
        [JsonProperty]
        private decimal baseCost;

        public MenuItem()
        {
            Description = "";
            BaseCost = 0;
        }


        public MenuItem(string description, decimal cost)
        {
            Description = description;
            BaseCost = cost;
        }

        [JsonProperty]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [JsonProperty]
        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }


        public override string ToString()
        {
            string result;
            result=$"Menu Item:\tDescription: {Description}\n\tBase Cost: {BaseCost:c}";
            return result;
        }
    }
}
