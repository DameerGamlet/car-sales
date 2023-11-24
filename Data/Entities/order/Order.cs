public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public decimal Price { get; set; }
    public string? Status { get; set; }

    public virtual Account? user { get; set; }
    public virtual Account? seller { get; set; }

    public virtual Car? Car { get; set; }

    public virtual ICollection<Payment>? Payments { get; set; }
}
