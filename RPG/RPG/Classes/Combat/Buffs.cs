using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public static class Buffs
    {
        public static bool berserk = false;
        public static bool evasion = false;
        public static bool focusedAim = false;
        public static bool focusResistance = false;
        public static bool regenerate = false;




        public static void ResetStatsAndBuffs(Combatant hero)
        {
            hero.AttackPower = hero.BaseAttackPower;
            hero.Defense = hero.BaseDefense;
            hero.SpellPower = hero.BaseSpellPower;
            hero.MagicDefense = hero.BaseMagicDefense;
            hero.CriticalHitRate = hero.BaseCritChance;
            hero.DodgeRate = hero.BaseDodge;
            hero.AbsorbAmount = 0;
            berserk = false;
            evasion = false;
            focusedAim = false;
            focusResistance = false;
            regenerate = false;
        }
    }
}
