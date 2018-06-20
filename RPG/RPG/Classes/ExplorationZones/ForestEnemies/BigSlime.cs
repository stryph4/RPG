using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes
{
    public class BigSlime : Combatant
    {
        static Random random = new Random();

        public BigSlime(string name, string classType) : base(name, classType)
        {
            HP = 75;
            MaxHP = 75;
            MP = 30;
            MaxMP = 30;
            Strength = 12;
            Agility = 12;
            Intelligence = 12;
            AttackPower = Strength * 1.5;
            SpellPower = Intelligence * 1.5;
            Defense = Strength / 3;
            MagicDefense = Intelligence / 3;
            CriticalHitRate = Agility * .43;
            DodgeRate = Agility * .25;
            Gold = 10;
            Experience = 10;
        }

        public override void EnemyTurn(Combatant hero, Combatant enemy)
        {
            Console.Clear();
            double enemyChoice = random.NextDouble();
            double critChance = random.NextDouble() * (100);
            double dodgeChance = random.NextDouble() * (100);

            if (enemy.MP >= 5 && enemyChoice > .5)
            {
                double damage = enemy.SpellPower - hero.MagicDefense * (random.Next(4, 5) - random.Next(2, 3));
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
                double damage = (enemy.AttackPower - hero.Defense) * (random.Next(1, 5) / 1.5);
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



