using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class CannibalGhost : Ghost
    {
        public CannibalGhost(string name) : base(name) { }
        public void Eat(Ghost g)
        {
            if (g == null)
            {
                throw new ArgumentNullException();
            }

            this.Size += g.Size;
            g.Size = 0;
        }

    }
}

