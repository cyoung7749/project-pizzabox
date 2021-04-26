using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class StoreSingleton
  {
    private const string _path = @"data/stores.xml";
    private readonly FileRepository _fileRepository = new FileRepository();
    private readonly PizzaBoxContext _context = new PizzaBoxContext();
    private static StoreSingleton _instance;

    public List<AStore> Stores { get; }
    
    public static StoreSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new StoreSingleton();
        }
        return _instance;
      }
    }
    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {

      if (Stores == null)
      {
        //_context.Stores.AddRange(_fileRepository.ReadFromFile<List<AStore>>(_path));
        _context.SaveChanges();
/*         Stores = new List<AStore>()
        {
          new EastCoast(),
        new WestCoast()
      }; */
        Stores = _context.Stores.ToList();
      }
    }
     public IEnumerable<AStore> ViewOrders(AStore store)
    {
      // lambda - lINQ (linq to objects)
      // EF Loading = Eager Loading
      var orders = _context.Stores //load all stores
                    .Include(s => s.Orders) // load all orders for all stores
                    .ThenInclude(o => o.Pizza) // load all pizzas for all orders
                    .Where(s => s.Name == store.Name); // LINQ = lang integrated query
      return orders.ToList();
    }
  }
}