using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game.Classes
{
    public static class Save
    {
        static string dir = "Saves";

        public static void SaveGame(Combatant hero)
        {

            Console.Write("Enter a name for your save file: ");
            Directory.CreateDirectory(dir);


            string path = Console.ReadLine();
            path = Path.Combine(dir, path + ".sv");
            StreamWriter sw = new StreamWriter(path, false);

            sw.WriteLine($"{hero.Name}|{hero.ClassType}");
            sw.WriteLine($"{hero.HP}|{hero.MaxHP}|{hero.MP}|{hero.MaxMP}");
            sw.WriteLine($"{hero.Agility}|{hero.Strength}|{hero.Intelligence}");
            sw.WriteLine($"{hero.AttackPower}|{hero.Defense}|{hero.CriticalHitRate}|{hero.DodgeRate}");
            sw.WriteLine($"{hero.Experience}|{hero.ExperienceToLevel}|{hero.Gold}|{hero.StatPoints}");

            foreach (var entry in hero.Inventory)
            {
                sw.Write($"{entry.Key}|{entry.Value}|");
            }

            sw.WriteLine();


            foreach (var entry in hero.Skills)
            {
                sw.Write($"{entry.Key}|{entry.Value}|");
            }

            Console.WriteLine("Game Saved.");
            sw.Close();
            Console.ReadKey();
            return;

        }
    }

}

