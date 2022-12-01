using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms;

public partial class FormCustomerAdd : FormNoCloseBase
{
    private IAppSettings _appSettings;
    private readonly ICustomerService _customerService;
    private bool first = false;
    private bool last = false;
    private bool phone = false;
    public FormCustomerAdd(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        InitializeComponent();
        btnConfirm.Enabled = false;
        ErrorText.Visible = false;
    }

    private void OnClickBtnBack(object sender, EventArgs e)
    {
        FormFactory.Get<FormCustomerList>().Show();
        this.Hide();
    }

    /// <summary>
    /// Series of text input boxes; once all boxes are filled and phone number is valid, the confirm button is enabled
    /// </summary>
    private void FirstNameText_TextChanged(object sender, EventArgs e)
    {
        if (FirstNameText.Text.Length != 0)
        {
            first = true;
        }
    }

    private void LastNameText_TextChanged(object sender, EventArgs e)
    {
        if (FirstNameText.Text.Length != 0)
        {
            last = true;
        }
    }

    private void PhoneText_TextChanged(object sender, EventArgs e)
    {
        if (PhoneText.Text.Replace("-", "").Replace(" ", "").Length == 9)
        {
            int tempNumChecker;
            phone = true;
            foreach (char c in PhoneText.Text.Replace("-", "").Replace(" ", "").ToCharArray())
            {
                if (!int.TryParse(c.ToString(), out tempNumChecker)) phone = false;
            }
            if (!phone) AddErrMessage("Phone number must not \ncontain any alphabetical characters!");
        }
        else if (first == true && last == true && phone == true)
        {
            btnConfirm.Enabled = true;
        }
        else
        {
            phone = false;
            btnConfirm.Enabled = false;
        }
    }

    /// <summary>
    /// Confirms that phone number is not already in use
    /// Write new customer to JSON file if not
    /// </summary>
    private void OnClickBtnConfirm(object sender, EventArgs e)
    {
        //phone format 000-000-0000
        string formattedPhone = Regex.Replace(PhoneText.Text.Replace("-", "").Replace(" ", ""), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");

        bool validPhone = true;

        foreach (Customer customer in _customerService.Customers.List)
        {
            if(formattedPhone == customer.Phone) validPhone = false;
        }

        if (validPhone)
        {
            //check if customer already exists
            Customer customer = _customerService.Customers[formattedPhone];

            //if not, create new customer with information from text fields
            if (customer == null)
            {
                customer = new Customer()
                {
                    Phone = formattedPhone,
                    FirstName = FirstNameText.Text,
                    LastName = LastNameText.Text,
                    RewardPointsBalance = 0,
                    Orders = new List<Order>()
                };
                _customerService.Customers.Add(customer);
                _customerService.Write();
            }

            FormCustomerList.c = customer;

            FormFactory.Get<FormDrinkOrder>().Show();
            this.Hide();
        }
        else
        {
            AddErrMessage("That Phone number is \nalready in use!");
        }
    }
    private void AddErrMessage(string message)
    {
        //set text in form to message
        ErrorText.Text = message;
        ErrorText.Visible = true;
    }
}
