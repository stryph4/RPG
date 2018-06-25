using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes
{
    public class BigSlime : Combatant
    {
        static Random random = new Random();

        public BigSlime(string name, string classType) : base(name, classType)
        {
            HP = 75;
            MaxHP = 75;
            MP = 30;
            MaxMP = 30;
            Strength = 12;
            Agility = 12;
            Intelligence = 12;
            AttackPower = Strength * 1.5;
            SpellPower = Intelligence * 1.5;
            Defense = Strength / 3;
            MagicDefense = Intelligence / 3;
            CriticalHitRate = Agility * .43;
            DodgeRate = Agility * .25;
            Gold = 10;
            Experience = 10;
        }

    }

}

    


