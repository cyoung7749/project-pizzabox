using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  public class StoreTests
  { //public declarations for testing reason
    //Test dummies or test harness
    public static IEnumerable<object[]> stores = new List<object[]>() //object is variable without datatype
        { // "Object" has a datatype so we don't want to typecast
            new object[] { new WestCoast()},
            new object[] { new EastCoast()}
        };  // ^ created a collection that holds stores for us to test.*

    /*[Fact]
    public void Test_RealPizza()
    {
      // arrange
      var sut = new RealPizza();

      // act
      var actual = sut.Name;
      //sut.Name = "dotnet";
      //actual = "dotnet";  // this should not happen

      // assert
      Assert.True(actual == "RealPizza");
      Assert.True(sut.ToString() == actual);
    } */
    [Theory]
    [MemberData(nameof(stores))]  //gets fed here from *
    public void Test_StoreName(AStore store)  //we're really testing datatypes, not really comparisons
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }
    /*
    [Theory]
    [InlineData("RealPizza")]
    [InlineData("Heresy")]
    public void Test_StoreNameSimple(string storeName)
    {
      Assert.NotNull(storeName);
    }
    [Fact]
    public void Test_Heresy()
    {
      var sut = new Heresy();
      var actual = sut.Name;
      Assert.True(actual == "Heresy");
      Assert.True(sut.ToString() == actual);
    } */
    // use [InLineData("sample text")] when putting a string into a test function. 
  }
}