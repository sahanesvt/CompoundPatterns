using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class QuackCounter:IQuackable
    {
        private IQuackable _duck;
        private static int _numberOfQuacks;
        private Observable _observable;
        private string _name;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(this);
            _name = duck.name();
        }

        public void quack()
        {
            _duck.quack();
            _numberOfQuacks++;
            notifyObservers();
        }

        public static int getQuacks()
        {
            return _numberOfQuacks;
        }

        public void notifyObservers()
        {
            _observable.notifyObservers();
        }

        public void registerObserver(IObserver observer)
        {
            _observable.registerObserver(observer);
        }

        public override string ToString()
        {
            return _name;
        }

        public string name()
        {
            return _name;
        }
    }
}
