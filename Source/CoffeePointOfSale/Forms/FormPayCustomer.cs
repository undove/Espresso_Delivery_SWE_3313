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
    public partial class FormPayCustomer : FormNoCloseBase
    {
        public string cardNumHolder = "";
        public string rewardsPoints = "";
        public string rewardsUsed = "";
        
        bool isGood = false;

        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;

        public static FormPayCustomer obj;

        public FormPayCustomer(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            ErrorText.Visible = false;
            obj = this;
        }

        //pay with points
        private void btnRewards_Click(object sender, EventArgs e)
        {
            verifyRewards(); // calling the method that verifies customers rewards points.
            if (isGood == true) {
                Close(); //closes this form
                FormFactory.Get<FormReceiptCustomerPoints>().Show(); //re-opens the main form
            } else if (isGood == false)
            {
                //I wanted to send an error that says they need to use their card. 
                AddErrMessage("Not enough reward points, please use your card");
            }
            
        }

        /// <summary>
        /// this verifies that the customer can use their rewards points by using static instances from several 
        /// forms to calculate whether or not the customer can use their rewards points. this also set the values for 
        /// string that will be used in the receipt screen for rewards points.
        /// </summary>
        private void verifyRewards()
        {

            int RWpoints = FormCustomerList.c.RewardPointsBalance;
            int NewRWPoints = RWpoints - FormDrinkOrder.obj.nRewardspoints; // this is the new rewards points for the customer
            int RWpointsused = FormDrinkOrder.obj.nRewardspoints;
            Customer c = FormCustomerList.c;
            if (RWpoints >= RWpointsused)
            {
                isGood = true;
                rewardsPoints = NewRWPoints.ToString();
                rewardsUsed = RWpointsused.ToString();
                c.RewardPointsBalance = NewRWPoints;
                _customerService.Write();

            } else
            {
                isGood = false;
            }
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
            if (inputBoxCVV.Text == "")
            {
                AddErrMessage("Please enter a CVV number first");
                numPassLuhn = false;
            }
            if (inputBoxCardNumber.Text == "")
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
                for (int x = cardNums.Length - 2; x > 0; x -= 2)
                {
                    cardNums[x] *= 2;
                    if (cardNums[x] > 9)
                    {
                        tempChars = cardNums[x].ToString().ToCharArray();
                        int newNum = 0;
                        foreach (char c in tempChars) newNum += int.Parse(c.ToString());
                        cardNums[x] = newNum;
                    }
                }
                int finalTotal = 0;
                foreach (int i in cardNums) finalTotal += i;
                if (finalTotal % 10 != 0)
                {
                    AddErrMessage("Invalid Card number");
                    numPassLuhn = false;
                }
            }

            if (numPassLuhn)
            {
                FormCustomerList.c.RewardPointsBalance += FormDrinkOrder.obj.rewardsGained;
                Close(); //closes this form
                FormFactory.Get<FormReceiptCustomerCard>().Show(); //re-opens the main form
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormDrinkOrder>().Show();
        }
    }
}
