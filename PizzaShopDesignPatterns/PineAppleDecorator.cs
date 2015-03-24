using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PineappleDecorator : IPizzaDecorator
    {
        public IPizzaComponent Pizza { get; set; }

        public int Price { get; set; }

        public PineappleDecorator(IPizzaComponent pizza)
        {
            this.Pizza = pizza;
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return Pizza.ToString() + " and Pineapple";
        }

        public void AddObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void AddObserver()
        {
            throw new NotImplementedException();
        }
    }
}
