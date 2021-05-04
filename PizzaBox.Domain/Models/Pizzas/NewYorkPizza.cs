using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
  /// <summary>
  /// 
  /// </summary>
  public class NewYorkPizza : APizza
  {
    /// <summary>
    /// 
    /// </summary>
    public override void AddCrust()
    {
      //Crust = crust ?? new Crust() { Name = "Thin" };
      Crust = new Crust();
      //Crust = crust;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddSize() //Size size = null
    {
      //Size = size ?? new Size() { Name = "Large" };
      //Size = size;
      Size = new Size();
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddToppings()//params Topping[] toppings
    {
      Toppings = new List<Topping>()
      {

      };
    }
  }
}
