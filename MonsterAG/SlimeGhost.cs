using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class SlimeGhost : Ghost
    {
        public SlimeGhost(string name)
            : base(name)
        {
        }
        public override string Haunt()
        {
            return this.Slime() + "\r\n" + base.Haunt();
        }

        public string Slime()
        {
            return (this.Name + " hinterlässt eine Schleimspur.");
        }
    }
}
