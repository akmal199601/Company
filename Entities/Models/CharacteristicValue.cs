namespace Entities.Models;

public class CharacteristicValue
{
    public Guid Id { get; set; }
    public Guid CharacteristicId { get; set; }
    public string Value { get; set; }

    public virtual Characteristic Characteristic { get; set; }
    public virtual IEnumerable<ProductCharacteristic> ProductCharacteristics { get; set; }
}