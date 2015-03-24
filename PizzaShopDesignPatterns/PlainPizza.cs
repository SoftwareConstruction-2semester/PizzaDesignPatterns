using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PlainPizza : IPizzaComponent
    {
        private int _price;

        public override string ToString()
        {
            return "Pizza with Tomatoes and cheese";
        }

        public void AddObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void AddObserver()
        {
            throw new NotImplementedException();
        }

        public PlainPizza()
        {
            _price = 50;
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
