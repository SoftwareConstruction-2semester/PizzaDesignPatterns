﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShopDesignPatterns
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
    }
}
