using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<AStore> Stores { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(""); //not a good idea for the connection string
      //
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<APizza>().HasKey(e => e.EntityId); //these are subject to change 
    }
  }
}