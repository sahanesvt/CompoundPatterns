using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public interface IQuackObservable
    {
        void registerObserver(IObserver observer);
        void notifyObservers();
    }
}
