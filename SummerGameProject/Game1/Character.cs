using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    public abstract class Character
    {
        /*private String name;
        private int maxHealth;
        private int currentHealth;
        private int damage;*/

        public String Name { get; set; }

        public int MaxHealth { get; set; }

        public int CurrentHealth { get; set; }

        public int Damage { get; set; }

        /*public Character(String name, int maxHealth, int damage)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.damage = damage;
        }*/

        public void DealDamage(Character target)
        {
            if (target.CurrentHealth - Damage >= 0) { target.CurrentHealth -= Damage; }

            else { target.CurrentHealth = 0; }
        }
    }
}
