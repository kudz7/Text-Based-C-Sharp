using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public abstract class weapon
    {

        public int damage;
        public string name;

        public int checkCritical()
        {
            Random random = new Random();
            int damageType = random.Next(0, 100);
            return damageType;
        }

    }

}