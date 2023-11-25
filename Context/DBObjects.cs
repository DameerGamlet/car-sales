using System;
using System.Linq;

public static class DBObject
{

	private static Dictionary<string, CarType>? types;

	public static Dictionary<string, CarType> CatTypes
	{
		get
		{
			if (types == null)
			{
				var list = new CarType[]{
					new CarType { Id = 1, Name = "Внедорожник" },
					new CarType { Id = 2, Name = "Спортивный" }
				};

				types = new Dictionary<string, CarType>();

				foreach (CarType carType in list)
				{
					types.Add(carType.Name, carType);
				}
			}
			return types;
		}
	}

	public static void Initialize(ApplicationDbContext context)
	{
		// если пустая таблица с категориями
		if (!context.CarTypes.Any())
		{
			context.CarTypes.AddRange(CatTypes.Select(c => c.Value));
		}

		// если пустая таблица с машинами
		if (!context.Cars.Any() && !context.CarTypes.Any())
		{
			context.AddRange(
				 new Car
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
					 Address = "Саратовская область, Саратов, Кировский район",
					 FuelTankCapacity = 90,
					 CarType = types["Внедорожник"]
				 }, new Car
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
					 FuelTankCapacity = 110,
					 Address = "Саратовская область, Балаково, Волжский район",
					 CarType = types["Внедорожник"]
				 }, new Car
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
					 FuelTankCapacity = 120,
					 Address = "Саратовская область, Саратов, Ленинский район",
					 CarType = types["Внедорожник"]
				 });

		}

		context.SaveChanges();

	}

}
