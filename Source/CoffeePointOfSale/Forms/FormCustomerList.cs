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
    public partial class FormCustomerList : FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private readonly ICustomerService _customerService;

        public string nameHolder = "";
        public int currentIndex;
        public static Customer c;
 
        public int rewardsBalance;

        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            

            foreach (Customer customer in _customerService.Customers.List)
            {
                customerBindingSource.Add(customer);
            }
        }

        private void OnClickBtnBack(object sender, EventArgs e)
        {
            FormFactory.Get<FormMain>().Show();
            this.Hide();
        }

        private void OnClickBtnAddCustomer(object sender, EventArgs e)
        {
            FormFactory.Get<FormCustomerAdd>().Show();
            this.Hide();
        }

        /// <summary>
        /// Searches customer list for matching index in the cell the user clicked on
        /// </summary>
        private void OnClickOrderCustomerList(object sender, DataGridViewCellEventArgs e)
        {
            int rowCount = 0;
            if (e.RowIndex == 0)
            {
                FormMain.isAnonymous = true;
                FormFactory.Get<FormDrinkOrder>().Show();
                this.Hide();
                return;
            }
            else
            {
                foreach (Customer customer in _customerService.Customers.List)
                {
                    if (rowCount == e.RowIndex)
                    {
                        nameHolder = customer.FirstName;
                        currentIndex = rowCount;
                        c = customer;
                        rewardsBalance = customer.RewardPointsBalance;
                        FormFactory.Get<FormDrinkOrder>().Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        rowCount++;
                    }
                }
            }
        }


    }
}
