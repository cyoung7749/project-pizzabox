using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Domain.Abstracts
{

  //[XmlInclude(typeof(CustomPizza))]
  //[XmlInclude(typeof(MeatPizza))]
  //[XmlInclude(typeof(VeggiePizza))]
  public abstract class APizza : AModel
  {
    public Crust Crust { get; set; }
    //public long CrustEntityId { get; set; }
    public Size Size { get; set; }
    //public long SizeEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    protected APizza()
    {
      Factory();
    }
    protected virtual void Factory()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    public abstract void AddCrust(Crust crust = null);
    public abstract void AddSize(Size size = null);
    public abstract void AddToppings(params Topping[] toppings);

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
