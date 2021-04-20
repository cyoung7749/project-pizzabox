using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;

namespace PizzaBox.Client.Singletons
{
  public class StoreSingleton
  {
    public static List<AStore> stores = new List<AStore>
    {
      new EastCoast(),
      new WestCoast()
    };
    public static StoreSingleton Instance
    {
      get
      {
        return new StoreSingleton();
      }
    }
    private StoreSingleton() { }
  }
}