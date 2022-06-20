namespace Entities.Models;

public class Users
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string? Address { get; set; }
    public Roles RoleId { get; set; }
    public string? ResetToken { get; set; }
    public DateTimeOffset? ResetTokenByLoginExpires { get; set; }
        
        
   // public virtual Role Role { get; set; }
    public virtual IEnumerable<Order> Orders { get; set; }
        
    public virtual IEnumerable<Otp> Otps { get; set; }
}