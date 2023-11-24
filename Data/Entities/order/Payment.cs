public class Payment
{
    public int Id { get; set; }
    public required int OrderId { get; set; }
    public required decimal Amount { get; set; }
    public required string PaymentMethod { get; set; }
    public DateTime Date { get; set; }

    public virtual Order? Order { get; set; }
}
