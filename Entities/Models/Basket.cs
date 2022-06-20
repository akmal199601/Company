namespace Entities.Models;

public class Basket
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public int Count { get; set; }

    public virtual Product Product { get; set; }
    public virtual Users User { get; set; }
}