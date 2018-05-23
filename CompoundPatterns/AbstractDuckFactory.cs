using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable createMallardDuck();
        public abstract IQuackable createRedheadDuck();
        public abstract IQuackable createDuckCall();
        public abstract IQuackable createRubberDuck();
    }
}
