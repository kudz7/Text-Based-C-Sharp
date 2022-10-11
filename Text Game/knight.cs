using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    public class knight : fighter
    {
        public knight()
        {
            this.name = "Knight";
            this.health = 30;
            this.weapon = new sword();
            this.armour = 30;
        }
    }
}
