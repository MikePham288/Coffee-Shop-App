using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{

    public class CustomerRepository:RepositoryBase
    {
        private static Customer[] customers;
        private int MAX_NUMBER_OF_CUSTOMERS = 10;
        private int numberOfCustomers;

        public override Customer[] Customers
        {
            get { return customers; }
            set {customers = value;} 
        }

        public CustomerRepository()
        {
            customers = new Customer[MAX_NUMBER_OF_CUSTOMERS];
        }

        public void Add(Customer customer)
        {
            if (numberOfCustomers <= MAX_NUMBER_OF_CUSTOMERS)
            {
                customers[numberOfCustomers++] = customer;
            }
            else
            {
                Console.WriteLine($"ERROR! Maximum number of customers reached!");
            }
        }

        //IEnumerable<Customer> CustomerWithNotDeliveredOrders()
        //{
        //    Customer customer=new Customer();
        //    return customer.Orders.Where(order => order == null).Select(order => customer);
        //}
        //IEnumerable<Customer>
        public IEnumerable<Customer> CustomerWithNotDeliveredOrders()
        {
            foreach (Customer customer in customers)
            {
                for (int i = 0; i <= customer.Orders.Length; i++)
                {
                    if (customer.Orders[i] != null)
                    {
                        if (customer.Orders[i].IsDelivered == false)
                        {
                            yield return customer;
                        }
                    }
                }
            }
            yield break;
        }

        public IEnumerable<Customer> OrderBetweenDates(DateTime start, DateTime end)
        {
            var test = from Customer customer in customers
                from Order order in customer.Orders
                where order.OrderTime >= start && order.OrderTime <= end
                select customer;
            return test.ToList();
                ;
        }



    }
}
