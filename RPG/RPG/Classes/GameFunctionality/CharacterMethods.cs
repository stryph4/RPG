using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RPG.Classes;

namespace RPG.Classes
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
                MessageBox.Show($"Congratulations!You have advanced to level{hero.Level} Your maximum HP has increased to {hero.MaxHP} and your maximum resource has increased to {hero.MaxMP}. You've earned 2 stat points!");
                hero.SkillPoints += 2;
                hero.HP = hero.MaxHP;
                hero.MP = hero.MaxMP;
                hero.Experience -= hero.ExperienceToLevel;
                hero.ExperienceToLevel = hero.Level * 12;
                Debuffs.ClearDebuffs();
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
            hero.Inventory["Potion"] = 5;
            hero.Inventory["Ether"] = 5;

            if (hero.ClassType == "Warrior")
            {
                hero.Skills.Add("Berserker (free)", "Increase attack power at the cost of defense.");
            }
            if (hero.ClassType == "Thief")
            {
                hero.Skills.Add("Poisoned Blade (10 MP)", "Basic attack which also poisons the enemy");
            }
            if (hero.ClassType == "Mage")
            {
                hero.Skills.Add("Fireball (20 MP)", "Hurl a ball of fire at the enemy");
            }
            if (hero.ClassType == "Paladin")
            {
                hero.Skills.Add("Heal (20 MP)", "Restores HP.");
            }
        }

    }
}


