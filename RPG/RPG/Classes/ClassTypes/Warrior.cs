using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Warrior : Combatant
    {
        public bool Berserker { get; set; }

        public Warrior(string name, string classType) : base (name, classType)
        {
            HP = 100;
            MaxHP = 100;
            MP = 30;
            MaxMP = 30;
            Strength = 20;
            Agility = 10;
            Intelligence = 5;
            AttackPower = Strength * 1.5;
            SpellPower = Intelligence;
            Defense = Strength / 2;
            MagicDefense = Intelligence / 5;
            CriticalHitRate = Agility * .43;
            DodgeRate = Agility * .25;
        }
    }
}
