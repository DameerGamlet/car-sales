using System.ComponentModel.DataAnnotations;

public class Account {
  public int Id { get; set; }

  [Required(ErrorMessage = "Имя продавца обязательно.")]
  public required string Name { get; set; }

  [Required(ErrorMessage = "Электронная почта обязательна.")]
  [EmailAddress(ErrorMessage = "Некорректный формат адреса электронной почты.")]
  public required string Email { get; set; }

  [Required(ErrorMessage = "Пароль обязателен.")]
  [DataType(DataType.Password)]
  public required string Password { get; set; }

  public string? City { get; set; }

  public virtual ICollection<FavoriteCar>? FavoriteCars { get; set; }
}