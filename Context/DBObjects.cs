public static class DBObject {

	private static Dictionary<int, CarType>? types;
	private static Dictionary<int, CarBrand>? brands;
	private static Dictionary<int, Car>? cars;

	public static Dictionary<int, CarType> CarTypes {
		get {
			if (types == null) {
				var list = new CarType[]{
					new CarType { Id = 1, Name = "Внедорожник" },
					new CarType { Id = 2, Name = "Спортивный" },
					new CarType { Id = 3, Name = "Седан" },
					new CarType { Id = 4, Name = "Хэтчбек" },
					new CarType { Id = 5, Name = "Универсал" },
					new CarType { Id = 6, Name = "Купе" },
					new CarType { Id = 7, Name = "Автобус" },
					new CarType { Id = 8, Name = "Мотоцикл" },
				};

				types = new Dictionary<int, CarType>();

				foreach (CarType carType in list) {
					types.Add(carType.Id, carType);
				}
			}
			return types;
		}
	}

	public static Dictionary<int, CarBrand> CarBrands {
		get {
			if (brands == null) {
				var list = new CarBrand[] {
					new CarBrand { Id = 1, Name = "LADA" },
					new CarBrand { Id = 2, Name = "Haval" },
					new CarBrand { Id = 3, Name = "Chery" },
					new CarBrand { Id = 4, Name = "Geely" },
					new CarBrand { Id = 5, Name = "Changan" },
					new CarBrand { Id = 6, Name = "OMODA" },
					new CarBrand { Id = 7, Name = "EXEED" },
					new CarBrand { Id = 8, Name = "Kia" },
					new CarBrand { Id = 9, Name = "Jetour" },
					new CarBrand { Id = 10, Name = "Renault" },
					new CarBrand { Id = 11, Name = "УАЗ" },
					new CarBrand { Id = 12, Name = "Toyota" },
					new CarBrand { Id = 13, Name = "Volkswagen" },
					new CarBrand { Id = 14, Name = "Skoda" },
					new CarBrand { Id = 15, Name = "Hyundai" },
					new CarBrand { Id = 16, Name = "Lexus" },
					new CarBrand { Id = 17, Name = "Citroen" },
					new CarBrand { Id = 18, Name = "Mitsubishi" },
					new CarBrand { Id = 19, Name = "Nissan" },
					new CarBrand { Id = 20, Name = "Mazda" },
					new CarBrand { Id = 21, Name = "SsangYong" },
					};

				brands = new Dictionary<int, CarBrand>();

				foreach (CarBrand carBrand in list) {
					brands.Add(carBrand.Id, carBrand);
				}
			}

			return brands;
		}
	}
	public static Dictionary<int, Car> Cars {
		get {
			if (cars == null) {
				var list = new Car[] {
					new Car {
						Id = 1,
						CarBrand = brands[12],
						Model = "LE",
						IconPreview = "https://www.pushcar.ru/img/public/2018/653_2.jpg",
						Horsepower = 80,
						Year = 2023,
						Mileage = 150,
						Condition = "Новый",
						Price = 2500000,
						EngineCapacity = 2.5,
						Transmission = "Автомат",
						Color = "Белый",
						Address = "Саратовская область, Саратов, Кировский район",
						FuelTankCapacity = 90,
						CarType = types[1]
					}, new Car {
						Id = 2,
						CarBrand = brands[5],
						Model = "EX",
						IconPreview = "https://627400.ru/wp-content/uploads/b/8/c/b8ce023291b3c4ec7cfbe4e1bd4edd14.jpeg",
						Horsepower = 90,
						Year = 2022,
						Mileage = 20000,
						Condition = "Хорошее",
						Price = 2200000,
						EngineCapacity = 2.0,
						Transmission = "Механика",
						Color = "Черный",
						FuelTankCapacity = 110,
						Address = "Саратовская область, Балаково, Волжский район",
						CarType = types[1]
					}, new Car {
						Id = 3,
						CarBrand = brands[12],
						Model = "Camry",
						IconPreview = "https://sportishka.com/uploads/posts/2022-04/1651179609_44-sportishka-com-p-mashini-obichnie-mashini-krasivo-foto-52.jpg",
						Horsepower = 100,
						Year = 2021,
						Mileage = 150,
						Condition = "Хорошее",
						Price = 800000,
						EngineCapacity = 1.4,
						Transmission = "Механика",
						Color = "Серебристый",
						FuelTankCapacity = 120,
						Address = "Саратовская область, Саратов, Ленинский район",
						CarType = types[1]
					},
					new Car {
						Id = 4,
						CarBrand = brands[11],
						Model = "Tucson",
						IconPreview = "https://krot.club/uploads/posts/2022-01/1642975204_9-krot-info-p-mashini-obichnie-10.jpg",
						Horsepower = 120,
						Year = 2023,
						Mileage = 10000,
						Condition = "Отличное",
						Price = 1800000,
						EngineCapacity = 2.0,
						Transmission = "Автомат",
						Color = "Серый",
						Address = "Саратовская область, Энгельс, Центральный район",
						FuelTankCapacity = 80,
						CarType = types[1]
					},
					new Car {
						Id = 5,
						CarBrand = brands[20],
						Model = "Sportage",
						IconPreview = "https://krot.club/uploads/posts/2022-01/1642975189_2-krot-info-p-mashini-obichnie-3.jpg",
						Horsepower = 110,
						Year = 2022,
						Mileage = 25000,
						Condition = "Отличное",
						Price = 2000000,
						EngineCapacity = 2.2,
						Transmission = "Автомат",
						Color = "Красный",
						Address = "Саратовская область, Саратов, Фрунзенский район",
						FuelTankCapacity = 70,
						CarType = types[1]
					},
					new Car {
						Id = 6,
						CarBrand = brands[14],
						Model = "Golf",
						IconPreview = "https://images.caradisiac.com/logos-ref/modele/modele--audi-tt/S0-modele--audi-tt.jpg",
						Horsepower = 95,
						Year = 2021,
						Mileage = 30000,
						Condition = "Хорошее",
						Price = 1500000,
						EngineCapacity = 1.8,
						Transmission = "Механика",
						Color = "Синий",
						Address = "Саратовская область, Саратов, Волгоградский район",
						FuelTankCapacity = 50,
						CarType = types[4]
					},
					new Car {
						Id = 7,
						CarBrand = brands[15],
						Model = "Corolla",
						IconPreview = "https://krot.club/uploads/posts/2022-01/1642975183_5-krot-info-p-mashini-obichnie-6.jpg",
						Horsepower = 105,
						Year = 2020,
						Mileage = 40000,
						Condition = "Хорошее",
						Price = 1700000,
						EngineCapacity = 1.6,
						Transmission = "Автомат",
						Color = "Белый",
						Address = "Саратовская область, Энгельс, Советский район",
						FuelTankCapacity = 55,
						CarType = types[3]
					}
				};

				cars = new Dictionary<int, Car>();

				foreach (Car car in list) {
					cars.Add(car.Id, car);
				}
			}

			return cars;
		}
	}

	public static void Initialize(ApplicationDbContext context) {
		// если пустая таблица с категориями
		if (!context.CarTypes.Any()) {
			context.CarTypes.AddRange(CarTypes.Select(c => c.Value));
		}

		// если пустая таблица с категориями
		if (!context.CarBrands.Any()) {
			context.CarBrands.AddRange(CarBrands.Select(c => c.Value));
		}

		// если пустая таблица с машинами
		if (!context.Cars.Any()) {
			// if (!context.Cars.Any() && !context.CarTypes.Any() && !context.CarBrands.Any()) {
			context.Cars.AddRange(Cars.Select(c => c.Value));
		}

		context.SaveChanges();
	}

}
