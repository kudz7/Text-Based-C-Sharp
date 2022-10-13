using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    public class hydra : fighter
    {
        public hydra()
        {
            this.name = "Hydra";
            this.weapon = new sword();
            this.health = 100;
            this.armour = 30;
        }
    }
}
