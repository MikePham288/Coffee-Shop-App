using CoffeeShopLib;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoffeeShop : Form
    {

        public Customer selectedCustomer = null;
        public CustomerRepository customerList = new CustomerRepository();


        public CoffeeShop()
        {
            InitializeComponent();
            Customer restaurant = new Customer("restaurant", 0, Address.SHOP_ADDRESS);
            customerList.Add(restaurant);
            lboxRestaurants.DataSource = customerList.Customers;
            btnOrder.Enabled = false;

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer(this);
            addCustomerForm.ShowDialog();
        }

        public void addCustomerToList(Customer customer)
        {
            lboxRestaurants.Items.Add(customer);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                EditCustomer editCustomerForm = new EditCustomer(selectedCustomer);
                editCustomerForm.ShowDialog();
            }
        }

        private void lboxRestaurants_SelectedValueChanged(object sender, EventArgs e)
        {
            btnOrder.Enabled = true;
            selectedCustomer = lboxRestaurants.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                int length = selectedCustomer.Orders.Length - 1;
                for (int i = length; i >= 0; i--)
                {
                    if (selectedCustomer.Orders[i] != null)
                    {
                        txbOrder.Text = selectedCustomer.Orders[i].ToString();
                        break;
                    }

                }
            }

        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrderForm = new AddOrder(this, selectedCustomer);
            addOrderForm.ShowDialog();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            CustomerOrders customerOrdersForm = new CustomerOrders(customerList);
            customerOrdersForm.ShowDialog();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value != null && dtpEnd.Value != null)
            {
                CustomerOrders customerOrdersForm = new CustomerOrders(customerList, dtpStart.Value, dtpEnd.Value);
                customerOrdersForm.ShowDialog();
            }
        }
    }
}
