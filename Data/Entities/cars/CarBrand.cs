public class CarBrand {

    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Country { get; set; }

    public virtual ICollection<Car>? Cars { get; set; }
}
