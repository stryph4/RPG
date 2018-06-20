using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Thief : Combatant

    {
        public bool Evasion { get; set; }

        public Thief(string name, string classType) : base (name, classType)
        {

            HP = 70;
            MaxHP = 70;
            MP = 30;
            MaxMP = 30;
            Strength = 10;
            Agility = 25;
            Intelligence = 10;
            AttackPower = (Strength / 2) + (Agility * 1.2);
            SpellPower = Intelligence;
            Defense = Agility / 5;
            MagicDefense = Intelligence / 5;
            CriticalHitRate = Agility * .3;
            DodgeRate = Agility * .30;


        }

    }
}
