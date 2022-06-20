namespace Entities.Models;

public class Brand
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImagePath { get; set; }

    public IEnumerable<Product> Products { get; set; }
}