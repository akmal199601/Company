namespace Entities.Models;

public class ProductCharacteristic
{
    public Guid ProductId { get; set; }
    public Guid CharacteristicValueId { get; set; }

    public virtual Product Product { get; set; }
    public virtual CharacteristicValue CharacteristicValue { get; set; }
}