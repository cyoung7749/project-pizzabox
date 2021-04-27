using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.NewTest
{
  public class NewTest
  {
    public static IEnumerable<object[]> stores = new List<object[]>() //object is variable without datatype
        { // "Object" has a datatype so we don't want to typecast
            new object[] { new WestCoast()},
            new object[] { new EastCoast()}
        };  // ^ created a collection that holds stores for us to test.*
    [Theory]
    [MemberData(nameof(stores))]  //gets fed here from *
    public void Test_StoreName(AStore store)  //we're really testing datatypes, not really comparisons
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }
    public static IEnumerable<object[]> pizzas = new List<object[]>()
    {
            new object[] { new NewYorkPizza()},
            new object[] { new CustomPizza()},
            new object[] { new ChicagoPizza()}
    };
    //object is variable without datatype 

    [Theory]
    [MemberData(nameof(pizzas))]
    public void Test_PizzaName(APizza pizza)
    {
      Assert.NotNull(pizza);
      // Assert.NotNull(pizza.EntityId);

      //Assert.NotEqual(pizza.EntityId, TestId)
      //Assert.NotNull(pizza.Size);
      //Assert.NotNull(pizza.Crust);
      Assert.NotNull(pizza.Toppings);
      //ssert.NotNull(pizza.EntityId);
      Assert.Equal(pizza.Crust.Name, pizza.Crust.ToString());
      Assert.Equal(pizza.Size.Name, pizza.Size.ToString());

    }
    public static IEnumerable<object[]> crust = new List<object[]>()
    {
            new object[] { new Crust()}
    };
    [Theory]
    [MemberData(nameof(crust))]
    public void Test_Crust(Crust crust)
    {
      Assert.NotNull(crust);
    }
    public static IEnumerable<object[]> size = new List<object[]>()
    {
            new object[] { new Size()}
    };
    [Theory]
    [MemberData(nameof(size))]
    public void Test_Size(Size size)
    {
      Assert.NotNull(size);
    }
    public static IEnumerable<object[]> customers = new List<object[]>()
    {
            new object[] { new Customer()}
    };
    [Theory]
    [MemberData(nameof(customers))]
    public void Test_CustomerName(Customer customer)
    {
      Assert.NotNull(customer);
    }
    public static IEnumerable<object[]> topping = new List<object[]>()
    {
            new object[] { new Topping()}
    };
    [Theory]
    [MemberData(nameof(topping))]
    public void Test_Topping(Topping topping)
    {
      Assert.NotNull(topping);
    }
    public static IEnumerable<object[]> orders = new List<object[]>()
    {
            new object[] { new Order()},
    };
    [Theory]
    [MemberData(nameof(orders))]
    public void Test_OrderTrue(Order orders)
    {
      Assert.NotNull(orders);
    }
  }
}