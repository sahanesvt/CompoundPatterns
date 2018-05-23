using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class RubberDuck:IQuackable
    {
        private Observable _observable;
        private string _name = "Rubber Duck";

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Squeak");
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
