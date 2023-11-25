public class Car {
    public int Id { get; set; }
    public required virtual CarBrand CarBrand { get; set; }
    public required string Model { get; set; }
    public string? IconPreview { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public string? Condition { get; set; }
    public decimal Price { get; set; }

    public virtual Account? Seller { get; set; }
    public virtual CarType? CarType { get; set; }
    public virtual Order? OrderItems { get; set; }

    public double EngineCapacity { get; set; }
    public string? Color { get; set; }
    // коробка передач
    public string? Transmission { get; set; }

    public string? Address { get; set; }

    public int Horsepower { get; set; }

    // New property for fuel tank capacity
    public double FuelTankCapacity { get; set; }
}
