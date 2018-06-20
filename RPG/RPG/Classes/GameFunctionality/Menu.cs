using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes
{
    public class Menu
    {

        public static void PrintMenu(Combatant hero)
        {
            while (true)
            {
                Console.Clear();
                string[] menuInputs = new string[7] { "1", "2", "3", "4", "5", "6", "Q" };
                string choice = "";
                
                while (!(menuInputs.Contains(choice)))
                {

                    Console.WriteLine($"Level: {hero.Level} Experience: {hero.Experience} / {hero.ExperienceToLevel}");
                    Console.WriteLine($"Gold: {hero.Gold} Stat Points: {hero.StatPoints}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("> What would you like to do?");
                    Console.WriteLine("> 1. Check Inventory");
                    Console.WriteLine("> 2. Choose a zone to explore.");
                    Console.WriteLine($"> 3. Rest at the Inn for 15 gold.");
                    Console.WriteLine("> 4. Print a list of your hero's skills.");
                    Console.WriteLine($"> 5. Spend stat points.");
                    Console.WriteLine("> 6. Save your current hero.");
                    Console.WriteLine("> Q. Quit to the main menu.");
                    choice = Console.ReadLine().ToUpper();

                }

                if (choice == "1")
                {
                    CheckInventory(hero);

                }

                if (choice == "2")
                {
                    ChooseZone(hero);
                }

                if (choice == "3")
                {
                    Rest(hero);

                }

                if (choice == "4")
                {
                    CheckSkills(hero);
                }

                if (choice == "5")
                {
                    IncreaseStats(hero);
                }

                if (choice == "6")
                {
                    SaveGame(hero);
                }

                if (choice == "Q")
                {
                    QuitGame(hero);
                }
            }

        }

        private static void QuitGame(Combatant hero)
        {
            string quitInput = "";
            string[] quitInputs = new string[2] { "Y", "N" };

            while (!quitInputs.Contains(quitInput))
            {
                Console.Clear();
                Console.WriteLine("Quit to the main menu? Any unsaved progress will be lost. (Y/N)");
                quitInput = Console.ReadLine().ToUpper();


                if (quitInput == "Y")
                {
                    System.Environment.Exit(1);
                }

                if (quitInput == "N")
                {
                    return;
                }

            }
        }

        private static void SaveGame(Combatant hero)
        {
            Save.SaveGame(hero);
            return;
        }

        private static void IncreaseStats(Combatant hero)
        {
            CharacterMethods.SpendStatPoints(hero);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            return;
        }

        private static void CheckSkills(Combatant hero)
        {
            Skills.PrintSkills(hero, hero.Skills);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        private static void CheckInventory(Combatant hero)
        {
            InventoryMethods.PrintInventory(hero.Inventory);
            Console.ReadKey();
            Console.WriteLine("Press any key to continue.");
            Console.Clear();
            return;
        }

        public static void ChooseZone(Combatant hero)
        {
            string[] validInputs = new string[2] { "1", "Q" };
            string input = "";

            while (!validInputs.Contains(input))
            {
                Console.Clear();
                Console.WriteLine("Choose a zone to explore:");
                Console.WriteLine("1. Forest");
                Console.WriteLine("Q. Return to menu");

                input = Console.ReadLine().ToUpper();

                if (input == "1")
                {
                    Forest.ExploreForest(hero);
                }
                if (input == "Q")
                {
                    return;
                }
            }

        }

        private static void Rest(Combatant hero)
        {
            if (hero.Gold >= 15)
            {
                hero.Gold -= 15;
                Debuffs.ClearDebuffs();
                hero.HP = hero.MaxHP;
                Console.WriteLine("HP/MP Restored and all status ailments cured!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            else
            {
                Console.WriteLine("Not enough gold!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }

        public static void StartMenu()
        {
            string[] validInputs = new string[2] { "1", "2" };
            string input = "";
            while (!validInputs.Contains(input))
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Load Game");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                Combatant hero = CharacterMethods.CreateCharacter();
                CharacterMethods.InitializeInventoryAndSpells(hero);
                PrintMenu(hero);
            }

            if (input == "2")
            {
                Combatant hero = Load.LoadGame();
                Console.Clear();
                PrintMenu(hero);
            }

        }

    }

}

