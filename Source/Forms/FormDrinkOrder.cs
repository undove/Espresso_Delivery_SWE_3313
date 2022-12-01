using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CoffeePointOfSale.Forms
{
    public partial class FormDrinkOrder : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        private IDrinkMenuService _drinkMenuService;

        public static FormDrinkOrder obj;
        public string DrinkOrder = "";
        public int nRewardspoints = 0;
        public int rewardsGained = 0;
        decimal Usingtotal = 0;

        //index of this array corresponds to the drink
        //ex. latte = 0 so when latte is selected (clicked on) it will update drinkList[0] = true
        private bool[] drinkList = new bool[] { false, false, false, false, false, false };
        public int drinkIndex;
        decimal subtotal = 0;

        public FormDrinkOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            obj= this;
            InitializeComponent();
        }

        private void FormDrinkOrder_Load(object sender, EventArgs e)
        {
            btnPlaceOrder.Enabled = false;
        }

        private void OnBtnClickCancel(object sender, EventArgs e)
        {
            FormFactory.Get<FormMain>().Show();
            this.Hide();
        }

        private void OnBtnClickLatte(object sender, EventArgs e)
        {
            drinkIndex = 0;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void OnBtnClickIcedLatte(object sender, EventArgs e)
        {
            drinkIndex = 1;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void OnBtnClickIcedMatcha(object sender, EventArgs e)
        {
            drinkIndex = 2;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void OnBtnClickCoffee(object sender, EventArgs e)
        {
            drinkIndex = 3;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void OnBtnClickEspresso(object sender, EventArgs e)
        {
            drinkIndex = 4;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void OnBtnClickIcedWater(object sender, EventArgs e)
        {
            drinkIndex = 5;
            customizationListBox.Items.Clear();
            LoadCustomizations();
        }

        private void LoadCustomizations()
        {
            //gets drink menu
            var dm = _drinkMenuService.DrinkMenu;
            //finds drink for index selected
            var drink = dm[drinkIndex];

            //loops through the customizations array in DrinkMenu.json and adds each to a new box in the list
            for (var i = 0; i < drink.Customizations.Count; i++)
            {
                var customization = drink.Customizations[i];
                customizationListBox.Items.Add(customization.ToString());
            }
        }

        private void OnClickBtnAddDrink(object sender, EventArgs e)
        {
            //enables paybutton since at least one drink is in cart
            btnPlaceOrder.Enabled = true;

            decimal tax, total, taxRounded;
            var dm = _drinkMenuService.DrinkMenu;
            var drink = dm[drinkIndex];

            //shows the items being added in the cart
            cartBox.AppendText(drink.Name + ": ");
            cartBox.AppendText(Convert.ToString(drink.BasePrice));
            foreach (int i in customizationListBox.CheckedIndices)
            {
                cartBox.AppendText(Environment.NewLine);
                cartBox.AppendText(drink.Customizations[i].ToString());
                subtotal += drink.Customizations[i].Price;
            }
            cartBox.AppendText(Environment.NewLine);
            cartBox.AppendText(Environment.NewLine);

            //calculates the subtotal, tax, and total
            subtotal += drink.BasePrice;
            tax = subtotal * _appSettings.Tax.Rate;
            taxRounded = Math.Round(tax, 2);
            total = subtotal + taxRounded;
            Usingtotal = total;

            //update labels
            labelSubtotalAmount.Text = (subtotal.ToString());
            labelTaxAmount.Text = (taxRounded.ToString());
            labelTotalAmount.Text=(total.ToString());

            //clear listbox
            customizationListBox.Items.Clear();
        }

        private void OnClickBtnPlaceOrder(object sender, EventArgs e)
        {
            RewardsPointsStuff();
            rewardsGained = RewardsGained();
            DrinkOrder = cartBox.Text;
            if (FormMain.isAnonymous == true)
            {
                FormFactory.Get<FormPayAnonymous>().Show();
                this.Hide();
            }
            else
            {
                FormFactory.Get<FormPayCustomer>().Show();
                this.Hide();
            }
        }


        void RewardsPointsStuff()
        {
            int rdTotal = (int)Math.Round(Usingtotal);
            nRewardspoints = rdTotal * 10;
        }
        int RewardsGained()
        {
            return (int)Math.Round(Usingtotal*_appSettings.Rewards.PointsPerDollar);
        }
    }
}