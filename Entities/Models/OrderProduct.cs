namespace Entities.Models;

public class OrderProduct
{
    public Guid OrderId { get; set; }
    public int Count { get; set; }
    public string VendorCode { get; set; }
    public double Price { get; set; }
    public double? Discount { get; set; }
    public string Name { get; set; }
    public virtual Order Order { get; set; }
    public string ImagePath { get; set; }
}