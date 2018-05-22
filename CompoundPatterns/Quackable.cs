using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public interface Quackable:IQuackObservable
    {
        void quack();
    }
}
