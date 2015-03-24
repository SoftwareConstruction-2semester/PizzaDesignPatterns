using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDesignPatterns
{
    public class PizzaFactoryOven : IObservable
    {
        Random random = new Random();

        private List<IObserver> _observers = new List<IObserver>(); 

        public IPizzaComponent GetPlainPizza()
        {
            return new PlainPizza();
        }

        public IPizzaComponent GetPepperoniPizza()
        {
            IPizzaComponent p = this.GetPlainPizza();
            return new PepperoniDecorator(p);
        }

        public IPizzaComponent GetPepperoniPineapplePizza()
        {
            IPizzaComponent pep = this.GetPepperoniPizza();
            return new PineappleDecorator(pep);
        }

        private IPizzaComponent GetChilliPepperoniPizza()
        {
            IPizzaComponent cp = this.GetPepperoniPizza();
            return new ChilliDecorator(cp);
        }
        public IPizzaComponent GetChilliPepperoniPineapplePizza()
        {
            IPizzaComponent c = this.GetChilliPepperoniPizza();
            IPizzaComponent c2 = new PineappleDecorator(c);
            preparePizza(c2);
            return c2;

        }

        

        private void NotifyObservers(String s)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(s);
            }
        }

        public void AddObserver(IObserver observer)
        {
           _observers.Add(observer); 
        }

        private void preparePizza(IPizzaComponent p)
        {
                       
            Task.Factory.StartNew(() =>
            {
                int preparetime = random.Next(5, 15);
                System.Threading.Thread.Sleep(preparetime*1000);  
                NotifyObservers(p.ToString());
            }); 
        }

        
    }
}
