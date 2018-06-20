using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes
{
    public class Slime : Combatant
    {
        static Random random = new Random();

        public Slime(string name, string classType) : base(name, classType)
        {

            HP = 50;
            MaxHP = 50;
            MP = 30;
            MaxMP = 30;
            Strength = 8;
            Agility = 8;
            Intelligence = 8;
            AttackPower = Strength * 1.5;
            SpellPower = Intelligence * 1.5;
            Defense = Strength / 3;
            MagicDefense = Intelligence / 3;
            CriticalHitRate = Agility * .43;
            DodgeRate = Agility * .25;
            Gold = 5;
            Experience = 5;
        }

        public override void EnemyTurn(Combatant hero, Combatant enemy)
        {
            Console.Clear();
            double enemyChoice = random.NextDouble();
            double critChance = CombatMain.CalculateDodgeAndCrit();
            double dodgeChance = CombatMain.CalculateDodgeAndCrit();

            if (enemy.MP >= 5 && enemyChoice > .5)
            {
                double damage = CombatMain.CalculateSpellDamage(enemy, hero);
                enemy.MP -= 5;
                Console.WriteLine($"{enemy.Name} attacks you with a poisonous gas.");
                if (critChance <= enemy.CriticalHitRate)
                {

                    damage *= 2;
                    damage = CombatMain.AbsorbCalculator(hero, (int)damage);


                    Console.WriteLine($"You take {(int)damage} damage. (CRITICAL)");

                    hero.HP -= (int)damage;
                    int poisonChance = random.Next(0, 10);
                    if (poisonChance >= 7)
                    {
                        Console.WriteLine("You are poisoned!");
                        Debuffs.heroPoisoned = true;
                    }

                }
                else
                {
                    damage = CombatMain.AbsorbCalculator(hero, (int)damage);

                    Console.WriteLine($"You take {(int)damage} damage.");
                    hero.HP -= (int)damage;
                    int poisonChance = random.Next(0, 10);
                    if (poisonChance >= 7)
                    {
                        Console.WriteLine("You are poisoned!");
                        Debuffs.heroPoisoned = true;
                    }
                }
            }

            else
            {
                double damage = CombatMain.CalculateAttackDamage(enemy, hero);
                if (dodgeChance <= hero.DodgeRate)
                {
                    Console.WriteLine($"{hero.Name} dodges {enemy.Name}'s attack.");

                }

                else if (critChance <= enemy.CriticalHitRate)
                {
                    damage *= 2;
                    damage = CombatMain.AbsorbCalculator(hero, (int)damage);
                    Console.WriteLine($"{enemy.Name} attacks {hero.Name} for {(int)damage} damage (CRITICAL).");
                    hero.HP -= (int)damage;
                }

                else
                {
                    damage = CombatMain.AbsorbCalculator(hero, (int)damage);
                    Console.WriteLine($"{enemy.Name} attacks {hero.Name} for {(int)damage} damage.");
                    hero.HP -= (int)damage;
                }

            }

        }

    }

}

