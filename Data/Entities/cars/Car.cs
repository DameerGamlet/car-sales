using System.ComponentModel.DataAnnotations;

public class Car {

  public int Id { get; set; }

  [Required(ErrorMessage = "Бренд автомобиля обязателен.")]
  public required virtual BrandCar BrandCar { get; set; }

  [Required(ErrorMessage = "Тип автомобиля обязателен.")]
  public virtual TypeCar? TypeCar { get; set; }

  [Required(ErrorMessage = "Модель автомобиля обязательна.")]
  public required string ModelCar { get; set; }

  public string? IconPreview { get; set; }

  [Required(ErrorMessage = "Год выпуска обязателен.")]
  public required int Year { get; set; }

  public int Mileage { get; set; }
  public string? Condition { get; set; }

  [Required(ErrorMessage = "Цена обязательна.")]
  public required decimal Price { get; set; }

  public virtual Account? Seller { get; set; }
  public virtual FavoriteCar? FavoriteCars { get; set; }

  public double EngineCapacity { get; set; }
  public string? Color { get; set; }
  // коробка передач
  public string? Transmission { get; set; }

  public string? Address { get; set; }

  public int Horsepower { get; set; }

  // New property for fuel tank capacity
  public double FuelTankCapacity { get; set; }
}