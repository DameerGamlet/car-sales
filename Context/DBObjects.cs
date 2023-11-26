public static class DBObject {

	private static Dictionary<int, CarType>? types;
	private static Dictionary<int, CarBrand>? brands;
	private static Dictionary<int, Car>? cars;

	public static Dictionary<int, CarType> CarTypes {
		get {
			if (types == null) {
				string[] list = {"Внедорожник","Спортивный","Седан","Хэтчбек","Универсал",
					"Купе","Автобус","Мотоцикл"
				};

				types = new Dictionary<int, CarType>();

				for (int i = 1; i != list.Length; i++) {
					types.Add(i, new CarType() { Id = i, Name = list[i] });
				}
			}
			return types;
		}
	}

	public static Dictionary<int, CarBrand> CarBrands {
		get {
			if (brands == null) {
				string[] tempList = {
					 "Lada", "Haval", "Chery", "Geely", "KIA", "Jetour", "Renault", "УАЗ", "Toyota", "Volkswagen",
					 "Skoda", "Hyundai", "Lexus", "Citroen", "Mitsubishi", "Nissan", "Mazda", "Alfa Romeo", "Audi", "BMW",
					 "Chevrolet", "Fiat", "Ford", "Honda", "Hyunday", "Infiniti", "Jaguar", "Jeep", "KIA", "Land Rover",
					 "Mersedes", "MG", "MINI", "Opel", "Peugeot", "Renault", "Seat", "Subaru", "Volvo",
					 };

				brands = new Dictionary<int, CarBrand>();

				for (int i = 1; i < tempList.Length; i++) {
					brands.Add(i, new CarBrand() { Id = i, Name = tempList[i - 1] });
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