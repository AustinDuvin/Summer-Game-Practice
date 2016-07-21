using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    class Character
    {
        private String name;
        private int maxHealth;
        private int currentHealth;
        private int damage;

        public Character(String name, int maxHealth, int damage)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.damage = damage;
        }
    }
}
