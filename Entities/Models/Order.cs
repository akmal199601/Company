namespace Entities.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTimeOffset OrderAt { get; set; }
    public Guid DeliveryTypeId { get; set; }
    public OrderStatuses OrderStatusId { get; set; }
    public Guid PaymentTypeId { get; set; }
    public string Description { get; set; }
    public virtual User User { get; set; }
    public virtual DeliveryType DeliveryType { get; set; }
    public virtual PaymentType PaymentType { get; set; }    
    public virtual OrderStatus OrderStatus { get; set; }
    public virtual IEnumerable<OrderProduct> OrderProducts { get; set; }
}