using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public class spider : fighter
    {
        public spider()
        {
            this.health = 10;
            this.armour = 0;
            this.name = "Spider";
            this.weapon = new knife();
        }
    }
}