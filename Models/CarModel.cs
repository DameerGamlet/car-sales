
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CarModel : PageModel
{
    private readonly ILogger<CarModel> _logger;

    public CarModel(ILogger<CarModel> logger)
    {
        _logger = logger;
    }


    public void OnGet()
    {
        ViewData["Title"] = "Каталог автомобилей";

        var car1 = new Car
        {
            CarBrand = new CarBrand { Name = "Toyota" },
            Model = "LE",
            IconPreview = "https://www.pushcar.ru/img/public/2018/653_2.jpg",
            Horsepower = 80,
            Year = 2023,
            Mileage = 10000,
            Condition = "Excellent",
            Price = 2500000,
            EngineCapacity = 2.5,
            Transmission = "Автомат",
            Color = "Белый",
            FuelTankCapacity = 90
        };

        car1.SetAddress("Московская область", "Москва", "Центральный район");

        var car2 = new Car
        {
            CarBrand = new CarBrand { Name = "Honda" },
            Model = "EX",
            IconPreview = "https://627400.ru/wp-content/uploads/b/8/c/b8ce023291b3c4ec7cfbe4e1bd4edd14.jpeg",
            Horsepower = 90,
            Year = 2022,
            Mileage = 20000,
            Condition = "Good",
            Price = 2200000,
            EngineCapacity = 2.0,
            Transmission = "Механика",
            Color = "Черный",
            FuelTankCapacity = 110
        };

        car2.SetAddress("Ленинградская область", "Санкт-Петербург", "Кировский район");

        var car3 = new Car
        {
            CarBrand = new CarBrand { Name = "Toyota" },
            Model = "Camry",
            IconPreview = "https://627400.ru/wp-content/uploads/4/c/8/4c8040c804d0bd1c03481cfde0cddaff.jpeg",
            Horsepower = 100,
            Year = 2021,
            Mileage = 150,
            Condition = "Good",
            Price = 800000,
            EngineCapacity = 1.4,
            Transmission = "Механика",
            Color = "Серебристый",
            FuelTankCapacity = 120
        };

        car3.SetAddress("Самарская область", "Самара", "Волжский район");


        List<Car> cars = new List<Car> { car1, car2, car3 };
        ViewData["Cars"] = cars;
    }
}
