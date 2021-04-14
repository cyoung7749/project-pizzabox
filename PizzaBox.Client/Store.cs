using System;

namespace PizzaBox.Client
{
    public class Store
    {
        string name;
        public Store()
        {
            name = "sToRe"; // change this
        }
        public override string ToString()
        {
            //return base.ToString();()
            //return "fake";
            return name;
        }
    }
}