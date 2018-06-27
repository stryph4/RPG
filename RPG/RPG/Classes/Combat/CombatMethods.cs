using RPG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RPG.Classes
{
    public class CombatMethods
    {
        public static bool yourTurn = true;
        public static bool inCombat = true;
        public static List<string> combatLog = new List<string>();

        public static double SpellAttack(Combatant attacker, Combatant defender, KeyValuePair<string, string> spell)
        {
            Random random = new Random();
            double damage = (attacker.SpellPower - defender.MagicDefense) * (random.NextDouble() + .1);
            if (damage < 0)
            {
                damage = 1;
            }
            return damage;
        }

        public static double SkillAttack(Combatant attacker, Combatant defender, KeyValuePair<string, string> spell)
        {
            Random random = new Random();
            double damage = (attacker.SpellPower - defender.MagicDefense) * (random.NextDouble() + .1);
            if (damage < 0)
            {
                damage = 1;
            }
            return damage;
        }
        public static void Attack(Combatant attacker, Combatant defender)
        {
            Random random = new Random();
            double damage = (attacker.AttackPower - defender.Defense) * (random.NextDouble() + .1);
            if (damage < 0)
            {
                damage = 1;
            }
            double dodge = CalculateDodgeAndCrit();
            double crit = CalculateDodgeAndCrit();
            if (dodge <= defender.DodgeRate)
            {
                combatLog.Insert(0, $"{defender.Name} dodges {attacker.Name}'s attack!");
            }
            else if (crit <= attacker.CriticalHitRate)
            {
                damage *= 2;
                damage = (AbsorbCalculator(defender, (int)damage));
                combatLog.Insert(0, $"{attacker.Name} hits {defender.Name} for {(int)damage} damage. (CRITICAL!)");
            }
            else
            {
                damage = (AbsorbCalculator(defender, (int)damage));
                combatLog.Insert(0, $"{attacker.Name} hits {defender.Name} for {(int)damage} damage.");
            }

            defender.HP -= (int)damage;

            RestoreRage(attacker, damage);

            if (attacker.ClassType == "Paladin")
            {
                    double tempAbsorb = damage * .2;
                    attacker.AbsorbAmount += (int)tempAbsorb;
            }
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

        public static void GenerateShield(Combatant hero)
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
                MessageBox.Show($"You win! You received {enemy.Gold + (int)extraGold} gold and {enemy.Experience} experience points!");
            }
            else
            {
                MessageBox.Show($"You win! You received {enemy.Gold} gold and {enemy.Experience} experience points!");
                hero.Gold += enemy.Gold;
            }
            hero.Experience += enemy.Experience;
            Buffs.ResetStatsAndBuffs(hero);
            inCombat = false;
            Debuffs.ClearEnemyDebuffs();
            CharacterMethods.LevelUp(hero);
            return;
        }

        public static void GameOver()
        {
            MessageBox.Show("You have died. Game Over.");
            Application.Current.Shutdown();
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
                combatLog.Insert(0, $"{tempDamage - damage} damage was absorbed by {combatant.Name}.");
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
