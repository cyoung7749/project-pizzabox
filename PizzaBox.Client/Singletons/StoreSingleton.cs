using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;

namespace PizzaBox.Client.Singletons
{
  public class StoreSingleton
  {
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
        //Stores = _fileRepository.ReadFromFile<List<AStore>>(_path);
        Stores = new List<AStore>();
      }
    }
  }
}