using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Customer
{
    internal class CSVExtract
    {
        public string? Phone { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? RPBal { get; set; }
        public DateTime? DateTime { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public string? PayMethod { get; set; }
        public string? PayDetails { get; set; }
        public int? PointsEarned { get; set; }
        public string? OrderInfo { get; set; }
    }
}
