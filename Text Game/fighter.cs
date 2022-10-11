using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public abstract class fighter
    {
        public string name;
        public int health;
        public weapon weapon;
        public int armour;

        public void attack(fighter target, weapon w)
        {
            target.health = (target.health + target.armour) - w.damage;
            if(target.armour > 0)
            {
                target.armour -= w.damage;

                if(target.armour < 0)
                {
                    target.armour = 0;
                }
            }
        }


    }

}