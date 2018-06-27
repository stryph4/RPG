using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Classes
{
    public static class ThiefSkills
    {
        //public static void Spellbook(Combatant hero, Combatant enemy)
        //{

        //    Console.Write("Enter the number of the skill to use: ");
        //    string skill = Console.ReadLine().ToLower();

        //    if (hero.Skills.ContainsKey(skill))
        //    {
        //        double critChance = CombatMethods.CalculateDodgeAndCrit();
        //        double dodgeChance = CombatMethods.CalculateDodgeAndCrit();
        //        if (skill == "1" && hero.MP >= 10)
        //        {
                    
        //            CastPoisonBlade(hero, enemy, skill, critChance, dodgeChance);
        //        }
        //        else
        //        {
        //            Skills.NotEnoughMP(hero, enemy);
        //        }
        //    }

        //    else
        //    {

        //    }

        //}

        //private static void CastPoisonBlade(Combatant hero, Combatant enemy, string skill, double critChance, double dodgeChance)
        //{
        //    double damage = CombatMethods.Attack(hero, enemy);

        //    hero.MP -= 10;
        //    if (dodgeChance <= enemy.DodgeRate)
        //    {
        //        CombatMethods.combatLog.Insert(0, $"Your poisoned blade was dodged by {enemy.Name}!");
        //        CombatMethods.yourTurn = false;
        //    }
        //    else if (critChance <= hero.CriticalHitRate)
        //    {
        //        damage *= 2;
        //        damage = CombatMethods.AbsorbCalculator(enemy, (int)damage);
        //        CombatMethods.combatLog.Insert(0, $"Your poisoned blade hit {enemy.Name} for {(int)damage} damage (CRITICAL).");
        //        Debuffs.enemyPoisoned = true;
        //        enemy.HP -= (int)damage;
        //        CombatMethods.yourTurn = false;
        //    }
        //    else
        //    {
        //        damage = CombatMethods.AbsorbCalculator(enemy, (int)damage);
        //        CombatMethods.combatLog.Insert(0, $"Your poisoned blade hit {enemy.Name} for {(int)damage} damage.");
        //        enemy.HP -= (int)damage;
        //        Debuffs.enemyPoisoned = true;
        //        CombatMethods.yourTurn = false;
        //    }

        //}

        private static void CastRegenerate()
        {
            Buffs.regenerate = true;
        }
    }
}
