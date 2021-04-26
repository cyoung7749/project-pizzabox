using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;

namespace PizzaBox.Domain.Abstracts
{
  //[XmlInclude(typeof(PUT MUH STORE HERE))]]
  [XmlInclude(typeof(EastCoast))]
  [XmlInclude(typeof(WestCoast))]
  public abstract class AStore : AModel
  {
    public string Name { get; set; } // does the same thing as public void GetName, SetName

    public List<Order> Orders { get; set; }

    // public AStore()
    public override string ToString()
    {
      return Name;
    }
  }
}