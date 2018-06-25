using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes


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
            //hero.HeroTurn(hero, enemy);
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
