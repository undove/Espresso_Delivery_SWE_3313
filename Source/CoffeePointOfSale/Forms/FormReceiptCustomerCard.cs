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
    public partial class FormReceiptCustomerCard : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;


        char[] cardinfoprocess;
        char[] anonCardinfo;

        string card = FormPayCustomer.obj.cardNumHolder;
        string items = FormDrinkOrder.obj.DrinkOrder;


        public FormReceiptCustomerCard(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();

            cardinfoprocess = card.ToCharArray();
            anonCardinfo = cardinfoprocess;
            setArray();       
            cartBox.Text = items;
            Cardinfo.Text = string.Concat(anonCardinfo);
            _customerService.Write();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        void setArray()
        {
            for (int i = anonCardinfo.Length-1; i >= 0; i--)
            {
                if(i > (anonCardinfo.Length - 5)) anonCardinfo[i] = cardinfoprocess[i];
                else anonCardinfo[i] = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cardinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
