namespace Entities.Models;

public class DeliveryType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double? Price { get; set; }

    public virtual IEnumerable<Order> Orders { get; set; }
}