using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PepperoniDecorator : IPizzaDecorator
    {
        public PizzaComponent Pizza { get; set; }

        public PepperoniDecorator(PizzaComponent pizza)
        {
            this.Pizza = pizza;
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return Pizza.ToString() + " and Pepperoni";
        }

        public int Price
        {
            get;
            set;
        }
    }
}
