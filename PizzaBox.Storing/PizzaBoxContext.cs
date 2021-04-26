using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    private readonly IConfiguration _configuration;
    public DbSet<AStore> Stores { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<Customer> Customers { get; set; }
  //public DbSet<Orders> Orders { get; set; } for repo design pattern

    public DbSet<Size> Sizes { get; set; }

    public PizzaBoxContext() //dependency injection way: (IConfiguration configuration)
    { //reading config way 
      _configuration = new ConfigurationBuilder().AddUserSecrets<PizzaBoxContext>().Build();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration["mssql"]); //not a good idea for the connection string
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<WestCoast>().HasBaseType<AStore>();
      builder.Entity<EastCoast>().HasBaseType<AStore>();

      builder.Entity<APizza>().HasKey(e => e.EntityId); //these are subject to change 
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      //builder.Entity<MORE PRESETS>().HasBaseType<APizza>();
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);

      builder.Entity<Customer>().HasKey(e => e.EntityId);
      OnDataSeeding(builder);
      }
      private void OnDataSeeding(ModelBuilder builder)
      {
       builder.Entity<EastCoast>().HasData(new EastCoast[] //params
        {  new EastCoast() { EntityId = 1, Name = "Mario's Pizzeria"}

        });
      builder.Entity<WestCoast>().HasData(new WestCoast[]
        {  new WestCoast()  { EntityId = 2, Name = "Bowser's Castle"}
        }); 
       
      builder.Entity<Customer>().HasData(new Customer[]
      {
        new Customer() { EntityId = 1, Name = "Mario Pardi" }
      }); 
      
    
    }
  }
}