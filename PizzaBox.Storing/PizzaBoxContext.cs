using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;
using System.Collections.Generic;


namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    private readonly IConfiguration _configuration;

    public DbSet<AStore> Stores { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; } //for repo design pattern
    public DbSet<Crust> Crust { get; set; }
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
      builder.Entity<AStore>().HasMany<Order>(s => s.Orders).WithOne(o => o.Store);
      builder.Entity<EastCoast>().HasBaseType<AStore>();
      builder.Entity<WestCoast>().HasBaseType<AStore>();

      builder.Entity<APizza>().HasKey(e => e.EntityId); //these are subject to change 
      builder.Entity<APizza>().HasMany<Order>().WithOne(o => o.Pizza);
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      builder.Entity<NewYorkPizza>().HasBaseType<APizza>();
      builder.Entity<ChicagoPizza>().HasBaseType<APizza>();

      builder.Entity<Size>().HasMany<APizza>().WithOne(p => p.Size);
      builder.Entity<Crust>().HasMany<APizza>().WithOne(p => p.Crust);
      //builder.Entity<MORE PRESETS>().HasBaseType<APizza>();

      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);

      builder.Entity<Customer>().HasKey(e => e.EntityId);
      builder.Entity<Customer>().HasMany<Order>().WithOne(o => o.Customer);


      //builder.Entity<Topping>().HasMany<APizza>().WithMany();

      OnDataSeeding(builder);
    }
    private void OnDataSeeding(ModelBuilder builder)
    {
      builder.Entity<EastCoast>().HasData(new EastCoast[] //params
     {  new EastCoast() { EntityId = 1, Name = "Mario Galaxy"}

     });
      builder.Entity<WestCoast>().HasData(new WestCoast[]
        {  new WestCoast()  { EntityId = 2, Name = "Luigi's Haunted Mansion"}
        });

      builder.Entity<Customer>().HasData(new Customer[]
      {
        new Customer() { EntityId = 1, Name = "Mario Pardi" }
      });
      builder.Entity<Customer>().HasData(new Customer[]
      {
        new Customer() { EntityId = 2, Name = "Mario Kart" }
      });

      /*       builder.Entity<Crust>().HasData(new Crust[]
            {
              new Crust() { EntityId = 1}
            });
            builder.Entity<Size>().HasData(new Size[]
            {
              new Size() { EntityId = 1}
            }); */

      /*       builder.Entity<CustomPizza>().HasData(new CustomPizza[]
           {
              new CustomPizza() {EntityId = 1, Crust = new Crust(), Size = new Size()}
           }); */
    }
  }
}