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
using static System.Windows.Forms.LinkLabel;

namespace CoffeePointOfSale.Forms
{
    public partial class FormReceiptAnonymous : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        char[] cardinfoprocess = new char[16];
        char[] anonCardinfo = new char[16];

        string card = FormPayAnonymous.obj.cardNumHolder;
        string items = FormDrinkOrder.obj.DrinkOrder;

        
        public FormReceiptAnonymous(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();

            cardinfoprocess = card.ToCharArray();
            anonCardinfo = cardinfoprocess;
            setArray();
            cartBox.Text = items;
            Cardinfo.Text = string.Concat(anonCardinfo);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void cartBox_TextChanged(object sender, EventArgs e)
        {

        }

        void setArray()
        {
            for (int i = anonCardinfo.Length - 1; i >= 0; i--)
            {
                if (i > (anonCardinfo.Length - 5)) anonCardinfo[i] = cardinfoprocess[i];
                else anonCardinfo[i] = '*';
            }
        }
    }
}