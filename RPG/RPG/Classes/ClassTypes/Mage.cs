using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Mage : Combatant
    {
        public Mage(string name, string classType) : base(name, classType)
        {
            HP = 55;
            MaxHP = 55;
            MP = 150;
            MaxMP = 150;
            Strength = 5;
            Agility = 5;
            Intelligence = 25;
            AttackPower = Strength / 5;
            SpellPower = Intelligence * 1.5;
            Defense = Strength / 3;
            MagicDefense = Intelligence / 2;
            CriticalHitRate = Intelligence * .08;
            DodgeRate = Agility * .25;

        }

    }
}

