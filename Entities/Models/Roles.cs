namespace Entities.Models;

public class Roles
{
    public Roles Id { get; set; }
    public string Name { get; set; }
    public virtual IEnumerable<User> Users { get; set; }
}
