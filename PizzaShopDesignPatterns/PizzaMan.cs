using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDesignPatterns
{
    class PizzaMan : IObserver
    {
        public void Notify(String s)
        {
            Console.WriteLine("ohhh a pizza is ready: "+s);
        }
    }
}
