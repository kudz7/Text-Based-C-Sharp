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
        public bool hasHealed;

        public void attack(fighter target, weapon w)
        {
            int damageModifier = w.checkCritical();
            int damage = (w.damage + damageModifier)  - target.armour;

            if(damage < 0)
            {
                damage = 0;
            }

            if(target.armour > 0)
            {
                target.armour -= (damageModifier + w.damage);

                if(target.armour < 0)
                {
                    target.armour = 0;
                }
            }

            if(target.armour == 0)
            {
                target.health -= damage;
            }
        }

        public void heal()
        {
            this.health += 10;
        }


    }

}