using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
  /// <summary>
  /// 
  /// </summary>
  public class ChicagoPizza : APizza
  {
    /// <summary>
    /// 
    /// </summary>
    public override void AddCrust()
    {
      // Crust = crust ?? new Crust() { Name = "Thick", Price = 4.00M };
      Crust = new Crust();
      //Crust = crust;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddSize() //Size size = null
    {
      //Size = size ?? new Size() { Name = "Small", Price = 4.00M };
      Size = new Size();
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddToppings()
    {
      Toppings = new List<Topping>()
      {
      };
    }
  }
}
