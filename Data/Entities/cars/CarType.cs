public class CarType
{
    public int Id { get; set; }
    public required string Class { get; set; }
    public required string BodyType { get; set; }
    public required string Engine { get; set; }

    public virtual ICollection<Car>? Cars { get; set; }
}
