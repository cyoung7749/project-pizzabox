using PizzaBox.Domain.Abstracts;    

namespace PizzaBox.Domain.Models
{
    public class Heresy : AStore //Heresy inherits from abstract class AStore
    {
        public Heresy()
        {
            Name = "Heresy";
        }
    }
}