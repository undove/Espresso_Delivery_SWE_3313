using CoffeePointOfSale.Services.Customer;

namespace CoffeePointOfSale.Services.DrinkMenu;

public interface IDrinkMenuService 
{
    public IReadOnlyList<Drink> DrinkMenu { get; init; }
}