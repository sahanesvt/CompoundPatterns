using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class MallardDuck: Quackable
    {
        private Observable _observable;

        public MallardDuck()
        {
            _observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void notifyObservers()
        {
            _observable.notifyObservers();
        }

        public void registerObserver(IObserver observer)
        {
            _observable.registerObserver(observer);
        }
    }
}
