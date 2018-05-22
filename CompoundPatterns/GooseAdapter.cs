using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    public class GooseAdapter:Quackable
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void quack()
        {
            _goose.honk();
        }
    }
}
