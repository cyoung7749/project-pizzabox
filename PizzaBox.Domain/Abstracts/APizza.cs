using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Domain.Abstracts
{

  [XmlInclude(typeof(CustomPizza))]
  //[XmlInclude(typeof(MeatPizza))]
  //[XmlInclude(typeof(VeggiePizza))]
  public abstract class APizza : AModel
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    //public long SizeEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    public APizza()
    {
      // Factory();
    }
    protected virtual void Factory()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected abstract void AddCrust();

    protected abstract void AddSize();

    protected abstract void AddToppings();

    public override string ToString()
    {
      var stringBuilder = new StringBuilder();
      var separator = ", ";

      foreach (var item in Toppings)
      {
        stringBuilder.Append($"{item}{separator}");
      }

      return $"{Crust} - {Size} - {stringBuilder.ToString().TrimEnd(separator.ToCharArray())}";
    }
  }
}
