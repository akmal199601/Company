namespace Entities.Models;

public class Favorite
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }

    public virtual Product Product { get; set; }
    public virtual User User { get; set; }
}
