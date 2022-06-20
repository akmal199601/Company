namespace Entities.Models;

public class PaymentType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public virtual IEnumerable<Order> Orders { get; set; }
}