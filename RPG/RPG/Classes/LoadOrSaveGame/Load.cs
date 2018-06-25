using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG.Classes
{
    public static class Load
    {

        public static Combatant LoadGame()
        {
            string dir = "Saves";
            Combatant hero = new Combatant("name", "class");
            string[] files = (Directory.GetFiles(dir));
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Type the name of the file to load: ");
            string path = Console.ReadLine();
            path = Path.Combine(dir, path);
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    string[] nameClass = sr.ReadLine().Split('|');
                    hero.Name = nameClass[0];
                    hero.ClassType = nameClass[1];

                    string[] hpMp = sr.ReadLine().Split('|');


                    hero.HP = int.Parse(hpMp[0]);
                    hero.MaxHP = int.Parse(hpMp[1]);
                    hero.MP = int.Parse(hpMp[2]);
                    hero.MaxMP = int.Parse(hpMp[3]);

                    string[] stats = sr.ReadLine().Split('|');


                    hero.Agility = int.Parse(stats[0]);
                    hero.Strength = int.Parse(stats[1]);
                    hero.Intelligence = int.Parse(stats[2]);

                    string[] damageModifiers = sr.ReadLine().Split('|');
                    hero.AttackPower = double.Parse(damageModifiers[0]);
                    hero.Defense = double.Parse(damageModifiers[1]);
                    hero.CriticalHitRate = double.Parse(damageModifiers[2]);
                    hero.DodgeRate = double.Parse(damageModifiers[3]);


                    string[] lvlGold = sr.ReadLine().Split('|');

                    hero.Experience = int.Parse(lvlGold[0]);
                    hero.ExperienceToLevel = int.Parse(lvlGold[1]);
                    hero.Gold = int.Parse(lvlGold[2]);
                    hero.SkillPoints = int.Parse(lvlGold[3]);

                    List<string> inventory = new List<string>(sr.ReadLine().Split('|'));
                    inventory.RemoveAt(inventory.Count - 1);

                    for (int i = 0; i < inventory.Count - 1; i += 2)
                    {
                        hero.Inventory[inventory[i]] = int.Parse(inventory[i + 1]);
                    }


                    List<string> skills = new List<string>(sr.ReadLine().Split('|'));

                    skills.RemoveAt(skills.Count - 1);

                    for (int i = 0; i < skills.Count - 1; i += 2)
                    {
                        hero.Skills[skills[i]] = (skills[i + 1]);
                    }

                }
                sr.Close();
                return hero;

            }
            else
            {
                Console.WriteLine("File not found. Press any key to return to the start menu.");
                Console.ReadKey();
                return null;
            }

        }

    }

}

