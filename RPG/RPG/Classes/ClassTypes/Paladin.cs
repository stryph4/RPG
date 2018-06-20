using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes.ClassTypes
{
    public class Paladin : Combatant
    {
        public Paladin(string name, string classType) : base(name, classType)
        {
            HP = 120;
            MaxHP = 120;
            MP = 60;
            MaxMP = 60;
            Strength = 10;
            Agility = 5;
            Intelligence = 15;
            AttackPower = Strength * 1.2;
            SpellPower = (Strength * .5) + (Intelligence * .5);
            Defense = Strength * .6;
            MagicDefense = Intelligence / 3;
            CriticalHitRate = Agility + Intelligence * .11;
            DodgeRate = Agility * .25;

        }
    }
}
