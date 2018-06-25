using RPG.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RPG.Classes
{
    public static class Forest
    {
        static Random random = new Random();
        static string zoneName = "Forest";


        public static void ExploreForest(Combatant hero)
        {
            CombatWindow combat = new CombatWindow();
            int explore = random.Next(0, 101);

            if (explore >= 50 && explore <= 90)
            {
                MessageBox.Show("You encountered a Big Slime!");
                combat.ShowDialog();
            }
            if (explore < 50)
            {

                MessageBox.Show("You encountered a Slime!");
                combat.ShowDialog();
            }
            if (explore > 90 && explore < 99)
            {
                int chest = random.Next(0, 11);
                if (chest < 3)
                {
                    int gold = random.Next(10, 20);
                    MessageBox.Show($"You found a chest containing {gold} gold!");
                    hero.Gold += gold;
                    return;

                }
                else if (chest >= 4 && chest <= 7)
                {
                    MessageBox.Show($"You found a chest containing a potion!");


                    return;
                }
                else
                {
                    MessageBox.Show($"You found a chest containing a mana potion!");
                    if (hero.Inventory.ContainsKey("Mana Potion"))
                    {
                        hero.Inventory["Mana Potion"] += 1;
                    }
                    else
                    {
                        hero.Inventory["Mana Potion"] = 1;
                    }
                    return;
                }
            }
            if (explore >= 99)
            {
                MessageBox.Show($"You found an experience shrine, and have been granted a free level!");
                hero.Experience += hero.ExperienceToLevel;
                CharacterMethods.LevelUp(hero);
                return;
            }
        }

    }
}
