using CoffeeShopLib;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerOrders : Form
    {
        public Customer selectedCustomer = null;
        public CustomerRepository customerRepository = null;
        public CustomerOrders(CustomerRepository repository)
        {
            InitializeComponent();
            customerRepository = repository;
            customerRepository.CustomerWithNotDeliveredOrders();
            lboxCustomer.DataSource = customerRepository.Customers;

        }

        public CustomerOrders(CustomerRepository repository, DateTime start, DateTime end)
        {

            InitializeComponent();
            customerRepository = repository;
            customerRepository.OrderBetweenDates(start, end);
            lboxCustomer.DataSource = customerRepository.Customers;

        }

        private void lboxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = lboxCustomer.SelectedItem as Customer;
            int length = selectedCustomer.Orders.Length - 1;
            if (selectedCustomer != null)
            {
                for (int i = length; i >= 0; i--)
                {
                    if (selectedCustomer.Orders[i] != null)
                    {
                        txtOrder.Text = selectedCustomer.Orders[i].ToString();
                        break;
                    }

                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
