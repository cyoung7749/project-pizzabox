using System.Collections.Generic;
using System;
using sc = System.Console; // only do this when you are being clear on the alias 

namespace PizzaBox.Client
{
    internal class Program
    {
        private static void Main()
        {
            List<string> storeList = new List<string> { "Store 001", "Store 002" };
            var stores = new List<Store>{ new Store(), new Store() }; // datatype reference
            // variables are camelcasing 
            // using List<string stores instead is choosing an explicit datatype
            for (var x = 0; x < stores.Count; x += 1)
            {
                // sc.WriteLine(x + " " + stores[x]);  //this is the old way
                Console.WriteLine($"{x} - {stores[x]}");
            }
            System.Console.WriteLine("make a selection: ");
            string input = sc.ReadLine();
            int entry = int.Parse(input);
            sc.WriteLine(stores[entry]);
        }
    }
}