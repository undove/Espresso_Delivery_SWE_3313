using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    public static FormMain user;
    public static bool isAnonymous = true;
    public FormMain(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
    }

    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().Show();
    }

    private void OnClickBtnDrinkOrder(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormDrinkOrder>().Show();
    }

    private void OnClickBtnCustomerList(object sender, EventArgs e)
    {
        isAnonymous = false;
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }

    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}