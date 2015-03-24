using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PlainPizza : PizzaComponent
    {
        private int _price;

        public override string ToString()
        {
            return "Pizza with Tomatoes and cheese";
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
