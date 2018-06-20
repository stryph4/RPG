using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class WarriorSkills
    {
        public static void Spellbook(Combatant hero, Combatant enemy)
        {
            Random random = new Random();

            Skills.PrintSkills(hero, hero.Skills);
            Console.Write("Enter the number of the skill to use: ");
            string skill = Console.ReadLine().ToLower();

            if (hero.Skills.ContainsKey(skill))
            {
                double critChance = random.NextDouble() * 100;

                if (skill == "1")
                {

                    CastBerserker(hero);
                }
                else
                {
                    Skills.NotEnoughMP(hero, enemy);
                    hero.HeroTurn(hero, enemy);

                }
            }
            else
            {
                Skills.SkillNotFound(hero, enemy);
                hero.HeroTurn(hero, enemy);

            }




        }

        public static void CastBerserker(Combatant hero)
        {
            if (Buffs.berserk == false)
            {
                Console.WriteLine("Berserker enabled, casting this spell again will disable the effect.");
                Buffs.berserk = true;
                hero.BaseAttackPower = hero.AttackPower;
                hero.AttackPower += hero.AttackPower * .1;
                hero.BaseDefense = hero.Defense;
                hero.Defense -= hero.Defense * .1;
            }

            else
            {
                Console.WriteLine("Berserker disabled.");
                Buffs.berserk = false;
                hero.AttackPower = hero.BaseAttackPower;
                hero.Defense = hero.BaseDefense;
            
            }
        }


    }
}
