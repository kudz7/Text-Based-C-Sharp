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

        public abstract int checkCritical();

    }

}