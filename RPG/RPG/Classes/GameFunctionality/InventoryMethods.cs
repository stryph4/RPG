using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game.Classes
{
    public class InventoryMethods
    {
        public static void PrintInventory(Dictionary<string, int> inventory)
        {
            Console.WriteLine();
            Console.WriteLine("Inventory:");
            Console.WriteLine();
            Console.WriteLine("Item Name".PadRight(25) + "Quantity");
            Console.WriteLine("----------------------------------------------");
            foreach (KeyValuePair<string, int> kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key.Substring(0, 1).ToUpper()}{kvp.Key.Substring(1)}".PadRight(25) + $"{kvp.Value}");
            }
        }

        public static void UseItem(Combatant hero, Combatant enemy)
        {
            PrintInventory(hero.Inventory);
            Console.Write("Type the name of the item to use:");
            string item = Console.ReadLine().ToLower();
            if (hero.Inventory.ContainsKey(item))
            {
                if (item == "potion" && hero.Inventory["potion"] > 0)
                {
                    double hpRestored = hero.MaxHP * .3;
                    hero.HP += (int)hpRestored;
                    hero.Inventory["potion"] -= 1;
                    Console.WriteLine($"{(int)hpRestored} HP was restored.");
                    if (hero.HP > hero.MaxHP)
                    {
                        hero.HP = hero.MaxHP;
                    }
                    CombatMain.yourTurn = false;
                }
                else if (item == "mana potion" && hero.Inventory["mana potion"] > 0)
                {
                    double mpRestored = hero.MaxHP * .3;
                    hero.HP += (int)mpRestored;
                    hero.Inventory["mana potion"] -= 1;
                    Console.WriteLine($"{(int)mpRestored} MP was restored.");
                    if (hero.HP > hero.MaxHP)
                    {
                        hero.MP = hero.MaxMP;
                    }
                    CombatMain.yourTurn = false;

                }

                else
                {
                    Console.WriteLine("The item was not found.");
                    hero.HeroTurn(hero, enemy);
                }


            }
        }

    }
}
