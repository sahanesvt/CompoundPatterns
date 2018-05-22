using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class QuackCounter:Quackable
    {
        private Quackable _duck;
        private static int _numberOfQuacks;

        public QuackCounter(Quackable duck)
        {
            _duck = duck;
        }

        public void quack()
        {
            _duck.quack();
            _numberOfQuacks++;
        }

        public static int getQuacks()
        {
            return _numberOfQuacks;
        }
    }
}
