using System.ComponentModel.DataAnnotations;

public class CarBrand {
    public int Id { get; set; }

    [Required(ErrorMessage = "Название бренда обязательно.")]
    public required string Name { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Car>? Cars { get; set; }
}
