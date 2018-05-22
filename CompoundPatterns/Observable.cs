using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }


        public void notifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                observer.update();
            }
        }

        public void registerObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
