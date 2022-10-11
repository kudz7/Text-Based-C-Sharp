using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    public class robber : fighter
    {
        public robber()
        {
            this.name = "Robber";
            this.health = 20;
            this.weapon = new sword();
            this.armour = 5;
        }
    }
}
