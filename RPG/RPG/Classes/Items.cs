using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Items
    {

        public static void UsePotion(Combatant hero)
        {
            if (hero.Inventory.Keys.Contains("Potion") && hero.Inventory["Potion"] > 0)
            {
                hero.HP += hero.MaxHP / 3;
                if (hero.HP > hero.MaxHP)
                {
                    hero.HP = hero.MaxHP;
                }
                CombatMethods.combatLog.Insert(0, $"{hero.Name} used a potion and restored {hero.MaxHP / 3} HP.");
            }
        }

    }
}
