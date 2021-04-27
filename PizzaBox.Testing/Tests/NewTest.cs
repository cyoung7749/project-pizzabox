using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;
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
    public static IEnumerable<object[]> pizzas = new List<object[]>()
    {
            new object[] { new NewYorkPizza()},
            new object[] { new CustomPizza()}
    };
    public static IEnumerable<object[]> pizzas = new List<object[]>()
    {
            new object[] { new NewYorkPizza()},
            new object[] { new CustomPizza()}
    };
    //object is variable without datatype 

    [Theory]
    [MemberData(nameof(pizzas))]
    public void Test_PizzaName(APizza pizza)
    {
      Assert.NotNull(pizza.Crust.Name);
      Assert.NotNull(pizza.Size.Name);
      //Assert.NotNull(pizza.Toppings);
      //Assert.Equal(pizza.Crust.Name, pizza.ToString());
    }
  }
}