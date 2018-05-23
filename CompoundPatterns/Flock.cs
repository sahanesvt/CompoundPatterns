using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class Flock: IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();
        //private Observable _observable;
        private string _name = "Flock of Ducks";

        public Flock()
        {
            //_observable = new Observable(this);
        }

        public void add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void quack()
        {
            foreach(IQuackable quacker in _quackers)
            {
                quacker.quack();
            }
            //notifyObservers();
        }

        public void notifyObservers()
        {
            foreach (IQuackable quacker in _quackers)
            {
                quacker.notifyObservers();
            }
            //_observable.notifyObservers();
        }

        public void registerObserver(IObserver observer)
        {
            foreach (IQuackable quacker in _quackers)
            {
                quacker.registerObserver(observer);
            }
            //_observable.registerObserver(observer);
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
