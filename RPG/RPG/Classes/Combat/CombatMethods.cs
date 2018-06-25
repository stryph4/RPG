﻿using RPG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPG.Classes
{
    public class CombatMain
    {
        public static bool yourTurn = true;
        public static bool inCombat = true;

        public static double CalculateSpellDamage(Combatant attacker, Combatant defender)
        {
            Random random = new Random();
            double damage = (attacker.SpellPower - defender.MagicDefense) * (random.NextDouble() + .1);
            if (damage < 0)
            {
                damage = 1;
            }
            return damage;
        }
        public static double CalculateAttackDamage(Combatant attacker, Combatant defender)
        {
            Random random = new Random();
            double damage = (attacker.AttackPower - defender.Defense) * (random.NextDouble() + .1);
            if (damage < 0)
            {
                damage = 1;
            }
            RestoreRage(attacker, damage);
            return damage;
        }

        public static void RestoreRage(Combatant attacker, double damage)
        {
            if (attacker.ClassType == "Warrior")
            {
                attacker.MP += (int)damage;
                if (attacker.MP > attacker.MaxMP)
                {
                    attacker.MP = attacker.MaxMP;
                }
            }
        }

        public static double CalculateDodgeAndCrit()
        {
            Random random = new Random();
            double rng = random.NextDouble() * 100;
            return rng;
        }

        private void PaladinTurn(Combatant hero)
        {
            double tempAbsorb = (double)hero.MaxHP * .02;
            hero.AbsorbAmount += (int)tempAbsorb;
        }

        private static void ThiefTurn(Combatant hero)
        {
            double tempEnergy = (double)hero.MaxMP * .03;
            hero.MP += (int)tempEnergy;
            if (hero.MP > hero.MaxMP)
            {
                hero.MP = hero.MaxMP;
            }
            if (Buffs.regenerate == true)
            {
                double tempHP = hero.MaxHP * .05;
                hero.HP += (int)tempHP;
                if (hero.HP > hero.MaxHP)
                {
                    hero.HP = hero.MaxHP;
                }
            }
        }

        public static void EndCombat(Combatant hero, Combatant enemy)
        {

            if (hero.ClassType == "Thief")
            {
                double extraGold = enemy.Gold * .2;
                Console.WriteLine($"You win! You received {enemy.Gold + (int)extraGold} gold and {enemy.Experience} experience points!");
            }
            else
            {
                Console.WriteLine($"You win! You received {enemy.Gold} gold and {enemy.Experience} experience points!");
                hero.Gold += enemy.Gold;
            }
            hero.Experience += enemy.Experience;
            Buffs.ResetStatsAndBuffs(hero);
            inCombat = false;
            Debuffs.ClearEnemyDebuffs();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            CharacterMethods.LevelUp(hero);
            return;
        }

        public static int AbsorbCalculator(Combatant combatant, int damage)
        {
            int tempDamage = (int)damage;
            damage -= combatant.AbsorbAmount;
            if (damage < 0)
            {
                damage = 0;
            }
            if (tempDamage < 0)
            {
                tempDamage = 0;
            }
            if (combatant.AbsorbAmount > 0 && tempDamage - damage > 0)
            {
                Console.WriteLine($"{tempDamage - damage} damage was absorbed.");
            }
            combatant.AbsorbAmount -= tempDamage;
            if (combatant.AbsorbAmount < 0)
            {
                combatant.AbsorbAmount = 0;
            }


            return damage;
        }
    }
}
