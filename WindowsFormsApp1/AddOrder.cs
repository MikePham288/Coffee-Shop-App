using CoffeeShopLib;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddOrder : Form
    {
        CoffeeDarkRoast coffeeDarkRoast;
        Tea tea;
        SandwichWithBacon sandwichWithBacon;
        SandwichWithEggSalad sandwichWithEggSalad;
        SandwichWithRoastedBeef sandwichWithRoastedBeef;
        CoffeeShopLib.MenuItem globalDrink;
        CoffeeShopLib.MenuItem globalFood;
        private CoffeeShop coffeeShopForm;
        public Customer customer;
        public Order order;
        OrderItem item;
        public AddOrder(CoffeeShop parent, Customer customer)
        {
            InitializeComponent();
            sandwichWithBacon = new SandwichWithBacon();
            sandwichWithEggSalad = new SandwichWithEggSalad();
            sandwichWithRoastedBeef = new SandwichWithRoastedBeef();
            coffeeShopForm = parent;
            this.customer = customer;
            order = new Order(customer, OrderType.PhoneOrder);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            customer.AddOrder(order);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (rbtnCoffee.Checked)
            {
                coffeeDarkRoast = new CoffeeDarkRoast();
                AddAdditions(coffeeDarkRoast);
            }
            if (rbtnTea.Checked)
            {
                tea = new Tea();
                AddAdditions(tea);
            }
            if (rbtnSandwichBacon.Checked)
            {
                sandwichWithBacon = new SandwichWithBacon();
                AddFoodAdditions(sandwichWithBacon);
            }
            if (rbtnSandwichRoastBeef.Checked)
            {
                sandwichWithRoastedBeef = new SandwichWithRoastedBeef();
                AddFoodAdditions(sandwichWithRoastedBeef);
            }
            if (rbtnSandwichEggSalad.Checked)
            {
                sandwichWithEggSalad = new SandwichWithEggSalad();
                AddFoodAdditions(sandwichWithEggSalad);
            }

            if (globalDrink!=null)
            {
                order.AddOrderItem(globalDrink); 
            }
            if (globalFood!=null)
            {
                order.AddOrderItem(globalFood); 
            }
            rbtnCoffee.Checked = false;
            rbtnTea.Checked = false;
            rbtnSandwichBacon.Checked = false;
            rbtnSandwichEggSalad.Checked = false;
            rbtnSandwichRoastBeef.Checked = false;
            numCheese.Value = 0;
            numLettuce.Value = 0;
            numMayo.Value = 0;
            numMilk.Value = 0;
            numSugar.Value = 0;
            numSweetner.Value = 0;
            numTomato.Value = 0;
            globalDrink = null;
            globalFood = null;
            txtOrder.Text = order.ToString();

        }

        private void AddAdditions(CoffeeShopLib.MenuItem drink)
        {

            if (numMilk.Value > 0)
            {
                drink = CreateDrinkWithMilk(drink, (int)numMilk.Value);
            }
            if (numSweetner.Value > 0)
            {
                drink = CreateDrinkWithSweetner(drink, (int)numSweetner.Value);
            }
            if (numSugar.Value > 0)
            {
                drink = CreateDrinkWithSugar(drink, (int)numSugar.Value);
            }
            globalDrink = drink;
        }
        private void AddFoodAdditions(CoffeeShopLib.MenuItem food)
        {

            if (numCheese.Value > 0)
            {
                food = CreateFoodWithCheese(food, (int)numMilk.Value);
            }
            if (numLettuce.Value > 0)
            {
                food = CreateFoodWithLettuce(food, (int)numSweetner.Value);
            }
            if (numTomato.Value > 0)
            {
                food = CreateFoodWithLettuce(food, (int)numSugar.Value);
            }

            if (numMayo.Value > 0)
            {
                food = CreateFoodWithMayo(food, (int)numMayo.Value);
            }
            globalFood = food;
        }

        private CoffeeShopLib.MenuItem CreateDrinkWithSugar(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength > 0)
            {
                item = new Sugar(CreateDrinkWithSugar(menuItem, --strength));
            }
            return item;
        }

        private CoffeeShopLib.MenuItem CreateDrinkWithMilk(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength != 0)
            {
                item = new Milk(CreateDrinkWithMilk(menuItem, --strength));
            }
            return item;
        }

        private CoffeeShopLib.MenuItem CreateDrinkWithSweetner(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength != 0)
            {
                item = new Sweetener(CreateDrinkWithSweetner(menuItem, --strength));
            }
            return item;
        }
        private CoffeeShopLib.MenuItem CreateFoodWithLettuce(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength > 0)
            {
                item = new Sugar(CreateFoodWithLettuce(menuItem, --strength));
            }
            return item;
        }

        private CoffeeShopLib.MenuItem CreateFoodWithTomato(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength != 0)
            {
                item = new Milk(CreateFoodWithTomato(menuItem, --strength));
            }
            return item;
        }

        private CoffeeShopLib.MenuItem CreateFoodWithCheese(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength != 0)
            {
                item = new Sweetener(CreateFoodWithCheese(menuItem, --strength));
            }
            return item;
        }
        private CoffeeShopLib.MenuItem CreateFoodWithMayo(CoffeeShopLib.MenuItem menuItem, int strength = 0)
        {
            CoffeeShopLib.MenuItem item = menuItem;
            if (strength != 0)
            {
                item = new Sweetener(CreateFoodWithMayo(menuItem, --strength));
            }
            return item;
        }


    }
}
