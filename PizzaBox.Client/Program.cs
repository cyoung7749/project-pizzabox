using System.Collections.Generic;
using System;
using sc = System.Console; // only do this when you are being clear on the alias 
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Client.Singletons;


//dotnet add PizzaBox.Client/PizzaBox.Client.csproj reference PizzaBox.Domain/PizzaBox.Domain.csproj 
// ^ will link the Abstracts together because now it knows where to go find the address
namespace PizzaBox.Client
{
  internal class Program
  {
    //Note that example code includes private static readonly List<Abstract class> _nameOfClass = new List<Ab>()
    // {
    // function calls go here to let us run example code.  
    // }  We're going to replace with with Singleton examplpe stuff
    private static void Main()
    {
      // List<string> storeList = new List<string> { "Store 001", "Store 002" };
      // var stores = new List<AStore>{ new RealPizza(), new Heresy() }; // datatype reference
      // // variables are camelcasing 
      // // using List<string stores instead is choosing an explicit datatype
      // for (var x = 0; x < stores.Count; x += 1)
      // {
      //     // sc.WriteLine(x + " " + stores[x]);  //this is the old way
      //     Console.WriteLine($"{x} - {stores[x]}");
      // }
      // System.Console.WriteLine("make a selection: ");
      // string input = sc.ReadLine();
      // int entry = int.Parse(input);
      // sc.WriteLine(stores[entry]);
      Run();
    }
    private static void Run()
    {
      // /*
      StoreSingleton ss = StoreSingleton.Instance;
      StoreSingleton.stores = null;
      //ss.stores = null;
      // */
      var order = new Order();

      Console.WriteLine("Welcome to PizzaBox");
      PrintStoreList();

      order.Customer = new Customer();
      order.Store = SelectStore();
      order.Pizza = SelectPizza();
    }
    private static void PrintOrder(APizza pizza)
    {
      Console.WriteLine($"Your order is {pizza}");
    }
    private static void PrintPizzaList()
    {
      var index = 0; //displays it on the screen, not needed

      foreach (var item in PizzaSingleton.pizzas) //like a for loop but no incrementor
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }
    private static void PrintStoreList()
    {
      var index = 0;

      foreach (var item in StoreSingleton.stores)
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }
    private static APizza SelectPizza()
    {
      var input = int.Parse(Console.ReadLine());
      var pizza = PizzaSingleton.pizzas[input - 1];

      PrintOrder(pizza);

      return pizza;
    }
    private static AStore SelectStore()
    {
      var input = int.Parse(Console.ReadLine());

      PrintPizzaList();

      return StoreSingleton.Stores[input - 1];
    }
  }
}