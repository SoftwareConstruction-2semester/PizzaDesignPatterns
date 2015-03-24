using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class ChilliDecorator : IPizzaDecorator
    {
        public PizzaComponent Pizza { get; set; }

        public ChilliDecorator(PizzaComponent pizza)
        {
            this.Pizza = pizza;
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return Pizza.ToString() + " and Chilli";
        }

        public int Price
        {
            get;
            set;
        }
    }
}
