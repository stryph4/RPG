using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes.ClassTypes;

namespace Game.Classes
{
    public static class CharacterMethods
    {
        public static bool WarriorSelected { get; set; }
        public static bool ThiefSelected { get; set; }
        public static bool MageSelected { get; set; }
        public static bool PaladinSelected { get; set; }
        public static string Name { get; set; }

        public static Combatant CreateCharacter()
        {


            if (WarriorSelected)
            {
                return new Warrior(Name, "Warrior");
            }

            if (ThiefSelected)
            {
                return new Thief(Name, "Thief");
            }

            if (MageSelected)
            {
                return new Mage(Name, "Mage");
            }

            if (PaladinSelected)
            {
                return new Paladin(Name, "Paladin");
            }

            return null;
        }



        public static void LevelUp(Combatant hero)
        {
            if (hero.Experience >= hero.ExperienceToLevel)
            {
                hero.Level++;
                double increaseHP = (double)hero.MaxHP + hero.MaxHP * .1;
                hero.MaxHP = (int)increaseHP;
                double increaseMP = (double)hero.MaxMP + hero.MaxMP * .1;
                hero.MaxMP = (int)increaseMP;
                Console.WriteLine($"Congratulations! You have advanced to level {hero.Level}!");
                Console.WriteLine($"Your maximum HP has increased to {hero.MaxHP} and your maximum resource has increased to {hero.MaxMP}");
                Console.WriteLine("You've earned 2 stat points!");
                hero.StatPoints += 2;
                hero.HP = hero.MaxHP;
                hero.MP = hero.MaxMP;
                hero.Experience -= hero.ExperienceToLevel;
                hero.ExperienceToLevel = hero.Level * 12;
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Debuffs.ClearDebuffs();
            }
        }

        public static void SpendStatPoints(Combatant hero)
        {
            string[] validInputs = new string[4] { "S", "A", "I", "Q" };
            string input = "";
            if (hero.StatPoints > 0)
            {

                while (!(validInputs.Contains(input)))
                {
                    Console.Clear();
                    Console.WriteLine("(S)trength");
                    Console.WriteLine("(A)gility");
                    Console.WriteLine("(I)ntelligence");
                    Console.WriteLine("(Q)uit to Main Menu");
                    Console.Write("Choose a stat to increase:");
                    input = Console.ReadLine().ToUpper();

                }

            }

            else
            {
                Console.WriteLine("You have no stat points to spend.");

            }

            if (input == "S")
            {
                hero.StatPoints--;
                hero.Strength++;
                Console.WriteLine("Your strength has been increased by 1 point.");
                UpdateStats(hero);

            }
            if (input == "A")
            {
                hero.StatPoints--;
                hero.Agility++;
                Console.WriteLine("Your agility has been increased by 1 point.");
                UpdateStats(hero);
            }
            if (input == "I")
            {
                hero.StatPoints--;
                hero.Intelligence++;
                Console.WriteLine("Your intelligence has been increased by 1 point.");
                UpdateStats(hero);
            }
            if (input == "Q")
            {
                return;
            }

        }

        public static void UpdateStats(Combatant hero)
        {
            if (hero.ClassType == "Mage")
            {
                hero.AttackPower = hero.Strength / 5;
                hero.SpellPower = hero.Intelligence * 1.5;
                hero.Defense = hero.Strength / 3;
                hero.MagicDefense = hero.Intelligence / 2;
                hero.CriticalHitRate = hero.Intelligence * .08;
                hero.DodgeRate = hero.Agility * .25;
            }
            if (hero.ClassType == "Thief")
            {
                hero.AttackPower = (hero.Strength / 2) + (hero.Agility * 1.5);
                hero.SpellPower = hero.Intelligence;
                hero.Defense = hero.Strength / 5;
                hero.MagicDefense = hero.Intelligence / 5;
                hero.CriticalHitRate = hero.Agility * .3;
                hero.DodgeRate = hero.Agility * .30;
            }

            if (hero.ClassType == "Warrior")
            {
                hero.AttackPower = hero.Strength * 1.5;
                hero.SpellPower = hero.Intelligence;
                hero.Defense = hero.Strength / 2;
                hero.MagicDefense = hero.Intelligence / 5;
                hero.CriticalHitRate = hero.Agility * .43;
                hero.DodgeRate = hero.Agility * .25;
            }


            if (hero.ClassType == "Paladin")
            {
                hero.AttackPower = hero.Strength * 1.2;
                hero.SpellPower = (hero.Strength * .5) + (hero.Intelligence * .5);
                hero.Defense = hero.Strength * .6;
                hero.MagicDefense = hero.Intelligence / 3;
                hero.CriticalHitRate = hero.Agility + hero.Intelligence * .11;
                hero.DodgeRate = hero.Agility * .25;
            }
        }

        public static void InitializeInventoryAndSpells(Combatant hero)
        {
            hero.Inventory["potion"] = 5;
            hero.Inventory["mana potion"] = 5;

            if (hero.ClassType == "Warrior")
            {
                hero.Skills.Add("1", "Berserker (free) Increase attack power at the cost of defense.");
            }
            if (hero.ClassType == "Thief")
            {
                hero.Skills.Add("1", "Poisoned Blade (10 energy) Basic attack which also poisons the enemy");
            }
            if (hero.ClassType == "Mage")
            {
                hero.Skills.Add("1", "Fireball (20 MP) Hurl a ball of fire at the enemy");
            }
            if (hero.ClassType == "Paladin")
            {
                hero.Skills.Add("1", "Heal (20 MP) Restores HP.");
            }

            Console.Clear();
        }

    }
}


