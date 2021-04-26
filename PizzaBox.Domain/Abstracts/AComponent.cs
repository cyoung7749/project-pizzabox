namespace PizzaBox.Domain.Abstracts
{

  //allows us to give us name and price to all subclasses that inherit
  public class AComponent
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public override string ToString()
    {
      return Name;
    }
  }
}