public class CarType {
    public int Id { get; set; }
    public required string Name { get; set; }
    public virtual ICollection<Car>? Cars { get; set; }
}
