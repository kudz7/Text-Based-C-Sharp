using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public class knife : weapon
    {

        public knife()
        {
            this.damage = 5;
            this.name = "knife";
        }

        public override int checkCritical()
        {
            Random random = new Random();
            int damageType = random.Next(0, 100);
            int extraDamage;

            if(damageType >=0 && damageType <= 5)
            {
                extraDamage = -this.damage;
                Console.WriteLine("Miss! No damage done!");
            }
            else if (damageType >= 6 && damageType <= 15)
            {
                extraDamage = 5;
                Console.WriteLine($"Critical hit! Extra {extraDamage} done!");
            }

            else if(damageType >= 16 && damageType <= 20)
            {
                extraDamage = 10;
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