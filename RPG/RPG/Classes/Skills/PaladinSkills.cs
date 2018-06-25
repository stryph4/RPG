using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes
{
    public class PaladinSkills
    {
        public static void CastHeal(Combatant hero, double critChance)
        {
            double healAmount = hero.SpellPower * .8;
            if (critChance <= hero.CriticalHitRate)
            {
                healAmount *= 2;
                hero.HP += (int)healAmount;
                Console.WriteLine($"Your Heal restored {healAmount} HP (CRITICAL).");
            }
            else
            {
                Console.WriteLine($"Your Heal restored {healAmount} HP.");
                hero.HP += (int)healAmount;
            }
            if (hero.HP > hero.MaxHP)
            {
                hero.HP = hero.MaxHP;
            }

        }

    }

}
