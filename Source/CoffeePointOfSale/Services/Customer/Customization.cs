using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Customer
{
    public class Customization //from mvc coffee
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string ToString()
        {
            return $"{Name}: {Price}, ";
        }
    }
}
