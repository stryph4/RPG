using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes
{
    public class Slime : Combatant
    {
        static Random random = new Random();

        public Slime(string name, string classType) : base(name, classType)
        {

            HP = 50;
            MaxHP = 50;
            MP = 30;
            MaxMP = 30;
            Strength = 8;
            Agility = 8;
            Intelligence = 8;
            AttackPower = Strength * 1.5;
            SpellPower = Intelligence * 1.5;
            Defense = Strength / 3;
            MagicDefense = Intelligence / 3;
            CriticalHitRate = Agility * .43;
            DodgeRate = Agility * .25;
            Gold = 5;
            Experience = 5;
        }

    }
}