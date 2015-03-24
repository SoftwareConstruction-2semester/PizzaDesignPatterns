﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PepperoniDecorator : IPizzaDecorator
    {
        public IPizzaComponent Pizza { get; set; }

        public PepperoniDecorator(IPizzaComponent pizza)
        {
            this.Pizza = pizza;
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return Pizza.ToString() + " and Pepperoni";
        }

        public void AddObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void AddObserver()
        {
            throw new NotImplementedException();
        }

        public int Price
        {
            get;
            set;
        }
    }
}
