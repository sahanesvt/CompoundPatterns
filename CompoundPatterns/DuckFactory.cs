using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable createDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable createMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable createRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable createRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
