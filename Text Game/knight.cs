using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    public class Knight : fighter
    {
        public Knight()
        {
            this.name = "Knight";
            this.health = 50;
            this.weapon = new sword();
            this.armour = 30;
        }
    }
}
