using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public class PizzaFactoryOven
    {
        public static PizzaComponent GetPlainPizza()
        {
            return new PlainPizza();
        }

        public static PizzaComponent GetPepperoniPizza()
        {
            PizzaComponent p = GetPlainPizza();
            return new PepperoniDecorator(p);
        }

        public static PizzaComponent GetChilliPepperoniPineapplePizza()
        {
            PizzaComponent pep = GetPepperoniPizza();
            ChilliDecorator c = new ChilliDecorator(pep);
            return  new PineappleDecorator(c);
        }

    }
}
