using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public static class Forest
    {
        static Random random = new Random();


        public static void ExploreForest(Combatant hero)
        {
            int explore = random.Next(0, 101);

            if (explore >= 50 && explore <= 90)
            {
                Console.WriteLine("You have encountered a Big Slime! Press any key to begin the encounter!");
                Console.ReadKey();
                CombatMain.StartCombat(hero, new BigSlime("Big Slime", "Enemy"));
            }
            if (explore < 50)
            {
                Console.WriteLine("You have encountered a Slime! Press any key to begin the encounter!");
                Console.ReadKey();
                CombatMain.StartCombat(hero, new Slime("Slime", "Enemy"));
            }
            if (explore > 90 && explore < 99)
            {
                Console.WriteLine("You found a chest! Press any key to open it!");
                Console.ReadKey();
                int chest = random.Next(0, 11);
                if (chest < 3)
                {
                    int gold = random.Next(10, 20);
                    Console.WriteLine($"You found {gold} gold!");
                    hero.Gold += gold;
                    return;

                }
                else if (chest >= 4 && chest <= 7)
                {
                    Console.WriteLine($"You found a potion!");
                    hero.Inventory["potion"] += 1;
                    return;
                }
                else
                {
                    Console.WriteLine("You found a mana potion!");
                    hero.Inventory["mana potion"] += 1;
                    return;
                }
            }
            if (explore >= 99)
            {
                Console.WriteLine("You found an experience shrine! You have been granted a free level!");
                hero.Experience += hero.ExperienceToLevel;
                CharacterMethods.LevelUp(hero);
                return;
            }
        }

    }
}
