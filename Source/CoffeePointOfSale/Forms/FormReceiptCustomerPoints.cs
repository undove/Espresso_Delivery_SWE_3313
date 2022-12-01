using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormReceiptCustomerPoints : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        string items = FormDrinkOrder.obj.DrinkOrder;
        string Usedpoints = FormPayCustomer.obj.rewardsUsed;
        string newBalance = FormPayCustomer.obj.rewardsPoints;

        public FormReceiptCustomerPoints (IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            cartBox.Text = items;
            RewardsPointsUsed.Text = Usedpoints;
            RemainingBalance.Text = newBalance; 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
