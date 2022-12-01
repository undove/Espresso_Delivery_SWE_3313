using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Customer
{
    public class Order
    {
        public DateTime? DateTime { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int PointsEarned { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentDetails { get; set; }
        public List<Drink> Drinks { get; set; } = new();

        string customStr = "";

        //for sales report
        public override string ToString()
        {
            foreach (var drink in Drinks)
            {
                customStr += " || " + drink.ToString();
                foreach (var customization in drink.Customizations)
                {
                    customStr += customization.ToString();
                }
            }
            return customStr;
        }
    }
}
