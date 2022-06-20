using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities;

public class DataContext :DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Baskets  { get; set; }
}