using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayAnonymous : FormNoCloseBase
    {
        public string cardNumHolder = "";
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        public static FormPayAnonymous obj;

        public FormPayAnonymous(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            ErrorText.Visible = false;
            obj= this;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormDrinkOrder>().Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool numPassLuhn = true;
            int tempNum;
            string cardNumber = inputBoxCardNumber.Text.Replace("-", "").Replace(" ", "");
            if (inputBoxCVV.Text.Length != 3 && inputBoxCVV.Text.Length != 4)
            {
                AddErrMessage("Invalid CVV");
                numPassLuhn = false;
            }
            if (!int.TryParse(inputBoxCVV.Text, out tempNum))
            {
                AddErrMessage("CVV must be a number");
                numPassLuhn = false;
            }
            if(inputBoxCVV.Text == "")
            {
                AddErrMessage("Please enter a CVV number first");
                numPassLuhn = false;
            }
            if(inputBoxCardNumber.Text == "")
            {
                AddErrMessage("Please enter a card number first");
                numPassLuhn = false;
            }
            else
            {
                char[] tempChars = cardNumber.ToCharArray();
                int[] cardNums = new int[tempChars.Length];
                for (int x = 0; x < tempChars.Length; x++)
                {
                    if (!int.TryParse(tempChars[x].ToString(), out cardNums[x]))
                    {
                        AddErrMessage("Card number must be a number");
                        return;
                    }
                }
                for(int x = cardNums.Length - 2; x > 0; x-=2)
                {
                    cardNums[x] *= 2;
                    if(cardNums[x] > 9)
                    {
                        tempChars = cardNums[x].ToString().ToCharArray();
                        int newNum = 0;
                        foreach(char c in tempChars) newNum += int.Parse(c.ToString());
                        cardNums[x] = newNum;
                    }
                }
                int finalTotal = 0;
                foreach (int i in cardNums) finalTotal += i;
                if(finalTotal % 10 != 0)
                {
                    AddErrMessage("Invalid Card number");
                    numPassLuhn = false;
                }
            }


            if (numPassLuhn)
            {
                Hide();
                FormFactory.Get<FormReceiptAnonymous>().Show();
            }
        }
        private void AddErrMessage(string message)
        {
            //set text in form to message
            ErrorText.Text = message;
            ErrorText.Visible = true;
        }

        private void inputBoxCardNumber_TextChanged(object sender, EventArgs e)
        {
            cardNumHolder = inputBoxCardNumber.Text;
        }
    }
}
