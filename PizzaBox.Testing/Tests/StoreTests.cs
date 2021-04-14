using System;
using Xunit;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.Tests
{

    public class StoreTests
    {
        [Fact]
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
        }
        [Fact]
        public void Test_Heresy()
        {
            var sut = new Heresy();
            var actual = sut.Name;
            Assert.True(actual == "Heresy");
            Assert.True(sut.ToString() == actual);
        }
    }
}