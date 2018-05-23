using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class DuckCall:IQuackable
    {
        private Observable _observable;
        private string _name = "Duck Call";

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Kwak");
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
