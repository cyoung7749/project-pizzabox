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
    public override void AddCrust(Crust crust = null)
    {
      Crust = crust ?? new Crust() { Name = "Thick" };
      //Crust = new Crust();
      //Crust = crust;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddSize(Size size = null) //Size size = null
    {
      Size = size ?? new Size() { Name = "Small" };
      //Size = size;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddToppings(params Topping[] toppings)
    {
      Toppings = new List<Topping>()
      {
        new Topping() { Name = "Mozzarella" },
        new Topping() { Name = "Chunky Tomato" },
        new Topping() { Name = "Sausage" },
        new Topping() { Name = "Pepperoni" }
      };
    }
  }
}
