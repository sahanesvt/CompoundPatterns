using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class Flock: Quackable
    {
        private List<Quackable> _quackers = new List<Quackable>();

        public void add(Quackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void quack()
        {
            foreach(Quackable quacker in _quackers)
            {
                quacker.quack();
            }
        }
    }
}
