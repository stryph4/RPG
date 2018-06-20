using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes
{
    public class PaladinSkills
    {

        public static void Spellbook(Combatant hero, Combatant enemy)
        {


            Skills.PrintSkills(hero, hero.Skills);
            Console.Write("Enter the number of the skill to use: ");
            string skill = Console.ReadLine().ToLower();

            if (hero.Skills.ContainsKey(skill))
            {
                double critChance = CombatMain.CalculateDodgeAndCrit();

                if (skill == "1" && hero.MP >= 20)
                {
                    hero.MP -= 20;
                    CastHeal(hero, critChance);
                }
                else
                {
                    Skills.NotEnoughMP(hero, enemy);
                }

            }
            else
            {
                Skills.SkillNotFound(hero, enemy);
            }
        }

        private static void CastHeal(Combatant hero, double critChance)
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