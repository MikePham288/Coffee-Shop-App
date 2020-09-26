using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable ]
    public class Customer
    {
        /*
         * Author: Le Minh Pham
         * Student Number: 300814556
         */
        private uint id;
        private string name;
        private Address address;
        private long phoneNumber;
        private Order[] orders;
        private static uint idCount = 1;
        private uint numberOfOrders;
        const uint MAX_NUMBER_OF_ORDERS = 50;
        [JsonProperty]
        public uint Id
        {
            get { return id; }
            private set { id = value; }
        }
        [JsonProperty]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonProperty]
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        [JsonProperty]
        public long Phone
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        [JsonProperty]
        public Order[] Orders
        {
            get { return orders; }
        }

        public Customer(string name, long phoneNumber,Address address)
        {
            id = idCount++;
            Name = name;
            Phone = phoneNumber;
            orders = new Order[MAX_NUMBER_OF_ORDERS];
        }

        public Customer()
        {
            id = idCount++;
            orders = new Order[MAX_NUMBER_OF_ORDERS];
        }


        //public string GetInfo()
        //{
        //    string result;
        //    result = $"ID: {id},\n\t  Name: {Name}, Phone number: {Phone}, Address: {address.GetInfo()} \n\tOrder:\n";
        //    for (int i = 0; i < numberOfOrders; i++)
        //    {

        //        result += $"\t\t{orders[i].GetInfo()}\n";

        //    }
        //    return result;
        //}
        public override string ToString()
        {
            string result;
            result = $"Customer:\tID: {id},\t  Name: {Name}, Phone number: {Phone}, Address: {address.GetInfo()} \n\tOrder:\n";
            for (int i = 0; i < numberOfOrders; i++)
            {

                result += $"\t\t{orders[i].ToString()}\n";

            }
            return result;
        }


        public void AddOrder(Order order)
        {
            if (numberOfOrders != MAX_NUMBER_OF_ORDERS)
            {
                orders[numberOfOrders++] = order;
                order.Customer=this;
            }
            else
            {
                Console.WriteLine($"You have added maximum number of orders!");
            };
        }

        public  Order CreatePhoneOrder(Address address)
        {
            Order order = new Order(this,OrderType.PhoneOrder);
            order.DeliveryAddress = address;

            if (numberOfOrders != MAX_NUMBER_OF_ORDERS)
            {
                orders[numberOfOrders++] = order;
            }
            else
            {
                Console.WriteLine($"You have added maximum number of orders!");
            }

            return order;
        }

        public void UpdateCustomer(string name, long number, Address address)
        {
            Name=name;
            Phone = number;
            Address = address;
        }
    }
    public struct Address
    {
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;
        public static readonly Address SHOP_ADDRESS = new Address("1 King St", "Toronto", "ON", "M1M 1M1");


        public string GetInfo()
        {
            return $"{Street} {Province} {City}, {PostalCode}";
        }

        public Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            Province = province;
            PostalCode=postalCode;

        }

    }
}
