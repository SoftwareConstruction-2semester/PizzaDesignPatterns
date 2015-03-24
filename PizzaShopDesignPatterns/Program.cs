using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlainPizza pizza = new PlainPizza();
            //PepperoniDecorator pepperoniPizza = new PepperoniDecorator(pizza);
            //ChilliDecorator chilliPepperoniPizza = new ChilliDecorator(pepperoniPizza);
            //Console.WriteLine(chilliPepperoniPizza);
            //Console.WriteLine(chilliPepperoniPizza.Price);
            PizzaMan pizzaMan = new PizzaMan();
            PizzaFactoryOven oven = new PizzaFactoryOven();
            oven.AddObserver(pizzaMan);

            IPizzaComponent pizza = oven.GetChilliPepperoniPineapplePizza();
            
            Console.WriteLine(pizza);
            Console.WriteLine(pizza.Price);

            Console.ReadLine();
        }
    }
}
