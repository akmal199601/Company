using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double? Discount { get; set; }
    public string Description { get; set; }
    public string VendorCode { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public bool HideProduct { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? BrandId { get; set; }
    public virtual Category Category { get; set; }
    public virtual Brand Brand { get; set; }
    public virtual IEnumerable<Comment> Comments { get; set; }
    public virtual IEnumerable<Basket> Baskets { get; set; }
    public virtual IEnumerable<Favorite> Favorites { get; set; }
    public virtual IEnumerable<ProductImage> ProductImages { get; set; }
    public virtual IEnumerable<ProductCharacteristic> ProductCharacteristics { get; set; }
}