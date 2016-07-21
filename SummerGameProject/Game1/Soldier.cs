using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    class Soldier : Character
    {
        public Soldier()
        {
            Name = "Soldier";
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            Damage = 20;
        }
    }
}
