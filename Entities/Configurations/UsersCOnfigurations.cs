using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configurations;

public class UsersCOnfigurations :IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.HasData(new Users
        {
            Id = Guid.NewGuid(),
            Address = "test",
            Email = "akmal199601@mail.ru",
            //RoleId = Roles.SuperAdmin,
            FirstName = "admin",
            LastName = "adminov",   
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("501502811a"),
            PhoneNumber = "test"
        });
    }
}