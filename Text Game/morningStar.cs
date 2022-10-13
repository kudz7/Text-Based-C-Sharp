using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    public class morningStar : weapon
    {
        public morningStar()
        {
            this.damage = 20;
            this.name = "Morning star";
        }

        public override int checkCritical()
        {
            Random random = new Random();
            int damageType = random.Next(0, 100);
            int extraDamage;

            if(damageType >= 0 && damageType <= 20)
            {
                extraDamage = -this.damage;
                Console.WriteLine("Miss! No damage done!");
            }

            else if(damageType >= 21 && damageType <= 50)
            {
                extraDamage = 10;
                Console.WriteLine($"Critical hit! Extra {extraDamage} done!");
            }

            else if(damageType >=51 && damageType <= 70)
            {
                extraDamage = 20;
                Console.WriteLine($" Major critical hit! Extra {extraDamage} done!");
            }

            else
            {
                extraDamage = 0;
            }

            return extraDamage;
        }
    }
}
