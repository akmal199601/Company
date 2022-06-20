namespace Entities.Models;

public class Characteristic
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<CharacteristicValue> CharacteristicValues { get; set; }
}