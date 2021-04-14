using PizzaBox.Domain.Abstracts;    

namespace PizzaBox.Domain.Models
{
    public class RealPizza : AStore //RealPizza inherits from abstract class AStore
    {
        public RealPizza()
        {
            Name = "RealPizza";
        }
    }
}