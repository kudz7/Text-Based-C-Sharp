﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{

    public class player : fighter
    {
        public player(string n)
        {
            this.health = 40;
            this.armour = 0;
            this.name = n;
            this.weapon = null;
        }
    }
}