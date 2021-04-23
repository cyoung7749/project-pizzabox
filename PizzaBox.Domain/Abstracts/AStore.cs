using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Abstracts
{
  public class AStore : AModel
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