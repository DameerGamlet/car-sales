using System.ComponentModel.DataAnnotations;

public class FavoriteCar {
  public int Id { get; set; }

  [Required(ErrorMessage = "Идентификатор пользователя обязателен.")]
  public int UserId { get; set; }

  [Required(ErrorMessage = "Идентификатор автомобиля обязателен.")]
  public int CarId { get; set; }

  public virtual Account? Account { get; set; }
  public virtual Seller? Seller { get; set; }
  public virtual Car? Car { get; set; }
}