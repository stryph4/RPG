using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes


{
    public static class Skills
    {
        static Random random = new Random();

        /// <summary>
        /// Indicates that the hero does not have enough MP to cast the given skill
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="enemy"></param>
        public static void NotEnoughMP(Combatant hero, Combatant enemy)
        {
            Console.WriteLine("Not enough resource! Try again.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            hero.HeroTurn(hero, enemy);
        }

        /// <summary>
        /// Indicates that the skill called was not found
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="enemy"></param>
        public static void SkillNotFound(Combatant hero, Combatant enemy)
        {
            Console.WriteLine("The skill could not be found! Try again.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            hero.HeroTurn(hero, enemy);
        }

        /// <summary>
        /// Prints the list of skills for your current hero
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="skills"></param>
        public static void PrintSkills(Combatant hero, Dictionary<string, string> skills)
        {
            Console.WriteLine("Skill:".PadRight(40) + "Description:");
            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (KeyValuePair<string, string> skill in skills)
            {
                Console.WriteLine(skill.Key.Substring(0, 1).ToUpper() + skill.Key.Substring(1).PadRight(40) + skill.Value);
            }
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        public static void SetBaseStats(Combatant hero)
        {
            hero.BaseAttackPower = hero.AttackPower;
            hero.BaseSpellPower = hero.SpellPower;
            hero.BaseDefense = hero.Defense;
            hero.BaseMagicDefense = hero.MagicDefense;
            hero.BaseCritChance = hero.CriticalHitRate;
            hero.BaseDodge = hero.DodgeRate;
        }

        

    }
}
