using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public class sword : weapon
    {

        public sword()
        {
            this.damage = 10;
            this.name = "sword";
        }

        public override int checkCritical()
        {
            Random random = new Random();
            int damageType = random.Next(0, 100);
            int extraDamage;

            if(damageType >= 0 && damageType <= 15)
            {
                extraDamage = -this.damage;
                Console.WriteLine("A miss! No damage done");
            }

            else if(damageType >= 16 && damageType <= 25)
            {
                extraDamage = 2;
                Console.WriteLine("Critical hit!");
            }

            else if(damageType >= 25 && damageType <= 29)
            {
                extraDamage = 5;
                Console.WriteLine("Major critical hit!");

            }

            else
            {
                extraDamage = 0;
            }

            return extraDamage;
        }

    }

}