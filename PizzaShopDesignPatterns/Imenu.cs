using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public interface Imenu
    {
         double TotalPrice { get; set; }

         String Drink { get; set; }

         String Food { get; set; }

    }
}
