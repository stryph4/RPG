using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Debuffs
    {
        //Hero Debuffs
        public static bool heroPoisoned = false;
        public static bool heroBleeding = false;
        public static bool heroStunned = false;

        //Enemy Debuffs
        public static bool enemyPoisoned = false;
        public static bool enemyBleeding = false;
        public static bool enemyStunned = false;

        public static void ClearDebuffs()
        {
            heroPoisoned = false;
            heroBleeding = false;
            heroStunned = false;

        }

        public static void ClearEnemyDebuffs()
        {
            enemyPoisoned = false;
            enemyBleeding = false;
            enemyStunned = false;
            
        }
    }


}
