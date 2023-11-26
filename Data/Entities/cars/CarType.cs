using System.ComponentModel.DataAnnotations;

public class CarType {
    public int Id { get; set; }

    [Required(ErrorMessage = "Название типа автомоибля обязательно.")]
    public required string Name { get; set; }
    public virtual ICollection<Car>? Cars { get; set; }
}
