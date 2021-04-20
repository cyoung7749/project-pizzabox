using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public class AStore
  {
    public string Name { get; set; } // does the same thing as public void GetName, SetName

    //public List<Order> Orders {get; set; }

    // public AStore()
    public override string ToString()
    {
      return Name;
    }
  }
}