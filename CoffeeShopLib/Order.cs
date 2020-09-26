using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable ]
    public class Order
    {
        /*
         * Author: Le Minh Pham
         * Student Number: 300814556
         */     
        const int MAX_NUMBER_ORDER_ITEMS = 50;
        int numberOfOrderItems;
        private uint id;
        private static uint idCount = 1;
        [JsonIgnore]
        private Customer customer;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private Address deliveryAddress;
        private decimal cost;
        private static OrderType orderType;
        private OrderItem[] items;
        private bool isDelivered;

        [JsonProperty]
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }
        [JsonIgnore]
        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (customer == null)
                {
                    customer = value;
                }
                else
                {
                    Console.WriteLine($"Something went wrong! Customer cannot be changed once assigned.");
                }
            }
        }
        [JsonProperty]
        public DateTime OrderTime
        {
            get { return orderTime; }
        }
        [JsonProperty]
        public Address DeliveryAddress
        {
            get { return deliveryAddress ; }
            set { deliveryAddress = value; }
        }
        [JsonProperty]
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        [JsonProperty]
        public OrderItem[] Items
        {
            get { return items; }
        }


        public Order()
        {
            Id = idCount++;
            orderTime = DateTime.Now;
            Cost = 0;
            orderType = OrderType.RestaurantOrder;
            items = new OrderItem[MAX_NUMBER_ORDER_ITEMS];
            deliveryAddress = Address.SHOP_ADDRESS;
            IsDelivered = true;
            //deliveryTime = DateTime.Now;
        }
        public Order(Customer customer, OrderType type)
        {
            Id = idCount++;
            orderTime = DateTime.Now;
            Cost = 0;
            orderType = type;
            items = new OrderItem[MAX_NUMBER_ORDER_ITEMS];
            IsDelivered = false;
            deliveryTime = DateTime.MinValue;
        }
        public bool IsDelivered
        {
            get { return isDelivered; }
            private set
            {
                isDelivered = value;                    
            }
        }
        public void Deliver()
        {
            IsDelivered = true;
            deliveryTime = DateTime.Now;
        }


        public void AddOrderItem(IMenuItem menuItem)
        {
            if (numberOfOrderItems<=MAX_NUMBER_ORDER_ITEMS)
            {
                items[numberOfOrderItems++] = new OrderItem(menuItem);
                cost += items[numberOfOrderItems-1].CalCost();
            }
            else
            {
                Console.WriteLine($"You have added maximum number of items!");
            }
        }


        public override string ToString()
        {
            string result;
            result = $"Order ID: {Id}, Ordered at :{orderTime.ToString("MM/dd/yyyy hh:mm tt")}, total cost {Cost:c}\n\t\tDelivery Address: {deliveryAddress.GetInfo()} \n\t\t";
            if (deliveryTime<OrderTime)
            {
                result += "Not yet delivered";
            }
            else
            {
                result += $"Delivered at: {deliveryTime.ToString("MM/dd/yyyy hh:mm tt")}";
            }

            result += "\n\t\t\tItems:\n";
            if (numberOfOrderItems>0)
            {
                for (int i = 0; i < numberOfOrderItems; i++)
                {

                    result += $"\t\t\t{items[i].ToString()}\n ";

                }
            }

            return result;
        }



    }


    public enum OrderType
    {
        PhoneOrder,
        RestaurantOrder
    }
}
