using System.Collections.Generic;
using System;
using System.Linq;
using sc = System.Console; // only do this when you are being clear on the alias 
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Client.Singletons;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

//dotnet add PizzaBox.Client/PizzaBox.Client.csproj reference PizzaBox.Domain/PizzaBox.Domain.csproj 
// ^ will link the Abstracts together because now it knows where to go find the address
namespace PizzaBox.Client
{
  public class Program
  {
    private static readonly PizzaBoxContext _context = new PizzaBoxContext();
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance(_context);
    private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance(_context);
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance(_context);
    private static readonly OrderRepository _orderRepository = new OrderRepository(_context);
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
      //RunEF();
    }
/*     private static void RunEF()
    {
      var context = new PizzaBoxContext();
      var stores = context.Stores;
      var customers = context.Customers;

      foreach (var  item in stores)
      {
        System.Console.WriteLine(item);
      }
      foreach (var  item in customers)
      {
        System.Console.WriteLine(item);
      }

    } */
    private static void Run()
    {
      // /*
      //StoreSingleton ss = StoreSingleton.Instance;
      //StoreSingleton.stores = null;
      //ss.stores = null;
      // */
      var order = new Order();

      Console.WriteLine("Welcome to PizzaBox");
      PrintListToScreen(_customerSingleton.Customers);

      //order.Customer = SelectCustomer();
      order.Store = SelectStore();
      order.Pizza = SelectPizza();

      //STORE THE ORDER HERE
      _orderRepository.Create(order);
      var orders = _context.Orders.Where(o => o.Customer.Name == order.Customer.Name);

      PrintListToScreen(orders);
      //STORE THE ORDER HERE 
    }
    private static void PrintOrder(APizza pizza)
    {
      Console.WriteLine($"Your order is {pizza}");
    }
    private static void PrintPizzaList()
    {
      var index = 0; //displays it on the screen, not needed
      Console.WriteLine("Choose your Pizza:");

      foreach (var item in _pizzaSingleton.Pizzas) //like a for loop but no incrementor
      {
        Console.WriteLine($"{++index} - {item}");
      }
    } 
    private static void PrintStoreList()
    {
      var index = 0;
      Console.WriteLine("Choose your Store:");

      foreach (var item in _storeSingleton.Stores) //basically a counting for loop but it does everything for you
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }
        private static void PrintListToScreen(IEnumerable<object> items)
    {
      var index = 0;

      foreach (var item in items)
      {
        Console.WriteLine($"{++index} - {item}");
      }
    }

    private static Customer SelectCustomer()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid)
      {
        return null;
      }

      var customer = _customerSingleton.Customers[input - 1];

      PrintStoreList();

      return customer;
    }
     private static APizza SelectPizza()
    {
       var valid = int.TryParse(Console.ReadLine(), out int input);
      if (!valid)
      {
        return null;
      } 
      var pizza = _pizzaSingleton.Pizzas[input - 1];
      PrintOrder(pizza);

      return pizza;
    } 
    private static AStore SelectStore()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);
      if (!valid)
      {
        return null;
      }
      PrintPizzaList();

      return _storeSingleton.Stores[input - 1];
    }
  }
}