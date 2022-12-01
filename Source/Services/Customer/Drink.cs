using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Customer
{
    public class Drink
    {
        public string? Name { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? TotalPrice { get; set; }

        private List<Customization> _customizations;

        public Drink(List<Customization> customizations)
        {
            _customizations = customizations;
        }

        public List<Customization> Customizations
        {
            get => _customizations;
            set => _customizations = value ?? new List<Customization>();
        }

        public string ToString()
        {
            var drink = "";
            drink += Name + ", Base Price: " + BasePrice + ", Total Price: " + TotalPrice;
            if (Customizations.Count > 0)
            {
                drink += "| Customizations: ";
            }
            return drink;
        }

        public void AddCustomization(Customization customization)
        {
            Customizations.Add(customization);
        }
    }
}
