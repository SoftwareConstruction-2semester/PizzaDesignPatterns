﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public interface IPizzaDecorator : PizzaComponent
    {
        PizzaComponent Pizza
        {
            get;
            set;
        }
    }
}
