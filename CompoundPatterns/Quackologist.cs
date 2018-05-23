using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class Quackologist : IObserver
    {
        public void update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked.");
        }
    }
}
