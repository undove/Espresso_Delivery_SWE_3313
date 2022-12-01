using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using Newtonsoft.Json;
using System.Reflection;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;
    public IReadOnlyList<Drink> DrinkMenu { get; init; }

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        var drinkMenuList = LoadDrinkMenuFromJsonFile();
        DrinkMenu = drinkMenuList.AsReadOnly();
    }

    //from mvc coffee
    private static List<Drink> LoadDrinkMenuFromJsonFile()
    {
        var execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string jsonPath = Path.Combine(execDir ?? throw new InvalidOperationException(),
            "JsonStorage",
            "DrinkMenu.json");
        var json = File.ReadAllText(jsonPath);
        var drinkMenuList = JsonConvert.DeserializeObject<List<Drink>>(json);
        if (drinkMenuList == null || !drinkMenuList.Any())
            throw new Exception($"Drink Menu JSON not found or empty at {jsonPath}");

        return drinkMenuList;
    }
}