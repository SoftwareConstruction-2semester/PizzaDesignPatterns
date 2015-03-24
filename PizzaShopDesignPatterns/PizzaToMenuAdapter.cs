using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PizzaToMenuAdapter : Imenu
    {
        public PizzaToMenuAdapter(IPizzaComponent pizza, string drink, double drinkPrice)
        {
            _food = pizza.ToString();
            _drink = drink;
            _drinkPrice = drinkPrice;
            _totalPrice = _pizza.Price + _drinkPrice;
        }

        private double _totalPrice;
        private readonly IPizzaComponent _pizza;
        private string _drink;
        private readonly double _drinkPrice;
        private string _food;

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public string Drink
        {
            get { return _drink; }
            set { _drink = value; }
        }

        public string Food
        {
            get { return _food; }
            set { _food = value; }
        }
    }
}
