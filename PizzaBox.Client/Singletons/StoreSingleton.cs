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
    private static StoreSingleton _instance;
    private readonly FileRepository _fileRepository = new FileRepository();
    private readonly PizzaBoxContext _context = new PizzaBoxContext();
    
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
        /* Stores = new List<AStore>()
        {
          new EastCoast(),
        new WestCoast()
      }; */
        Stores = _context.Stores.ToList();
      }
    }
  }
}