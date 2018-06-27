using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class WarriorSkills
    {

        public static void CastBerserker(Combatant hero)
        {
            if (Buffs.berserk == false)
            {
                CombatMethods.combatLog.Insert(0, "Berserker enabled, casting this spell again will disable the effect.");
                Buffs.berserk = true;
                hero.BaseAttackPower = hero.AttackPower;
                hero.AttackPower += hero.AttackPower * .1;
                hero.BaseDefense = hero.Defense;
                hero.Defense -= hero.Defense * .1;
            }

            else
            {
                CombatMethods.combatLog.Insert(0, "Berserker disabled.");
                Buffs.berserk = false;
                hero.AttackPower = hero.BaseAttackPower;
                hero.Defense = hero.BaseDefense;
            
            }
        }


    }
}
