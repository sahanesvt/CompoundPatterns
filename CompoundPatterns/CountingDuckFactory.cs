﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override Quackable createDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override Quackable createMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override Quackable createRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override Quackable createRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
