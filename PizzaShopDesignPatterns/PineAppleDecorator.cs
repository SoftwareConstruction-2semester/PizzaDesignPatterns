using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PineappleDecorator : IPizzaDecorator
    {
        public PizzaComponent Pizza { get; set; }

        public int Price { get; set; }

        public PineappleDecorator(PizzaComponent pizza)
        {
            this.Pizza = pizza;
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return Pizza.ToString() + " and Pineapple";
        }
    }
}
