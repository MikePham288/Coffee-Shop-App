using CoffeeShopLib;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditCustomer : Form
    {
        Customer customer;
        public EditCustomer(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone.ToString();
            txtStreet.Text = customer.Address.Street;
            txtCity.Text = customer.Address.City;
            txtProvince.Text = customer.Address.Province;
            txtPostalCode.Text = customer.Address.PostalCode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            long phoneNumber;
            long.TryParse(txtPhone.Text, out phoneNumber);
            Address address = new Address(
                txtStreet.Text,
                txtCity.Text,
                txtProvince.Text,
                txtPostalCode.Text
                );
            customer.UpdateCustomer(txtName.Text, phoneNumber, address);
            Close();
        }
    }
}
