using CsvHelper;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System.Diagnostics;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private IAppSettings _appSettings;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    private void OnClickBtnSalesReport(object sender, EventArgs e)
    {
        ConvertToCSV();
    }

    /// <summary>
    /// Converts the JSON information to a CSV file and then opens that in Excel.
    /// </summary>
    private void ConvertToCSV()
    {
        var csvList = new List<CSVExtract>();

        //customers x orders x drinks
        foreach (var customer in _customerService.Customers.List)
        {
            foreach (var order in customer.Orders)
            {
                var input = new CSVExtract
                {
                    Phone = customer.Phone,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    RPBal = customer.RewardPointsBalance,
                    DateTime = order.DateTime,
                    Subtotal = order.Subtotal,
                    Tax = order.Tax,
                    Total = order.Total,
                    PayMethod = order.PaymentMethod,
                    PayDetails = order.PaymentDetails,
                    PointsEarned = order.PointsEarned,
                    OrderInfo = order.ToString()
                };
    
                csvList.Add(input);
            }
        }


        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
        var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

        //write csvExtractLines via CSVHelper
        using (var writer = new StreamWriter(csvPathAndFilename))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(csvList);
        }

        //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
        try
        {
            var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
            {
                WorkingDirectory = outputDirectory,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
        }

    }
}

