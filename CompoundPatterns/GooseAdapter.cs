using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class GooseAdapter:IQuackable
    {
        private Goose _goose;
        private Observable _observable;
        private string _name = "Goose pretending to be a Duck";

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void quack()
        {
            _goose.honk();
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
