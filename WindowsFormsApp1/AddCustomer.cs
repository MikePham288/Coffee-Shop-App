using CoffeeShopLib;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddCustomer : Form
    {
        Customer customer;
        CoffeeShop parent;
        public AddCustomer(CoffeeShop parent)
        {
            InitializeComponent();
            customer = new Customer();
            this.parent = parent;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            customer.Name = Convert.ToString(txtName.Text);
            customer.Phone = Convert.ToInt64(txtNumber.Text);
            Address address = new Address(
                txtStreet.Text,
                txtCity.Text,
                txtProvince.Text,
                txtPostalCode.Text
                );
            customer.Address = address;
            parent.addCustomerToList(customer);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
