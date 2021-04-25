using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    private readonly IConfiguration _configuration;
    public DbSet<AStore> Stores { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    public PizzaBoxContext(IConfiguration configuration)
    {
      _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration["mssql"]); //not a good idea for the connection string
      //
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<APizza>().HasKey(e => e.EntityId); //these are subject to change 
    }
  }
}