using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes
{
    public class MageSkills
    {

        public static void Spellbook(Combatant hero, Combatant enemy)
        {

            Console.Write("Enter the number of the skill to use: ");
            string skill = Console.ReadLine().ToLower();

            if (hero.Skills.ContainsKey(skill))
            {
                double critChance = CombatMain.CalculateDodgeAndCrit();

                if (skill == "1" && hero.MP >= 20)
                {

                    CastFireball(hero, enemy, skill, critChance);
                }

                if (skill == "2" && hero.MP >= hero.MaxMP / 20)
                {
                    CastMagicShield(hero);
                }

            }


            else if (!hero.Skills.ContainsKey(skill))
            {

            }
            else
            {
                Skills.NotEnoughMP(hero, enemy);
            }

        }

        private static void CastMagicShield(Combatant hero)
        {
            hero.AbsorbAmount += hero.MaxMP / 20;
            hero.MP -= hero.MaxMP / 20 * 2;
            Console.WriteLine($"You converted {hero.MaxMP / 20} into a shield that absorbs damage.");
        }

        private static void CastFireball(Combatant hero, Combatant enemy, string skill, double critChance)
        {
            hero.MP -= 20;
            double damage = CombatMain.CalculateSpellDamage(hero, enemy);
            if (critChance <= hero.CriticalHitRate)
            {
                damage *= 2;
                damage = CombatMain.AbsorbCalculator(enemy, (int)damage);
                Console.WriteLine($"Your fireball hit {enemy.Name} for {(int)damage} damage (CRITICAL).");
                enemy.HP -= (int)damage;
                CombatMain.yourTurn = false;
            }
            else
            {
                damage = CombatMain.AbsorbCalculator(enemy, (int)damage);
                Console.WriteLine($"Your fireball hit {enemy.Name} for {(int)damage} damage.");
                enemy.HP -= (int)damage;
                CombatMain.yourTurn = false;
            }
        }
    }
}
