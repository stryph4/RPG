using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RPG.Classes;
using System.Threading;

namespace RPG.Classes
{
    public class Combatant
    {
        /// <summary>
        /// The combatant's current health points
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// The combatant's maximum health points
        /// </summary>
        public int MaxHP { get; set; }

        /// <summary>
        /// The combatant's current magic points
        /// </summary>
        public int MP { get; set; }

        /// <summary>
        /// The combatant's maximum magic points
        /// </summary>
        public int MaxMP { get; set; }

        /// <summary>
        /// The combatant's strength attribute
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// The combatant's agility attribute
        /// </summary>
        public int Agility { get; set; }

        /// <summary>
        /// The combatant's intelligence attribute
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// Calculates the combatant's attack power
        /// </summary>
        public double AttackPower { get; set; }

        /// <summary>
        /// Combatant's base attack power before buffs
        /// </summary>
        public double BaseAttackPower { get; set; }

        /// <summary>
        /// Calculates the combatant's spell power
        /// </summary>
        public double SpellPower { get; set; }

        /// <summary>
        /// Combatant's base spell power before buffs
        /// </summary>
        public double BaseSpellPower { get; set; }

        /// <summary>
        /// The combatant's defense
        /// </summary>
        public double Defense { get; set; }

        /// <summary>
        /// The combatant's base defense before buffs
        /// </summary>
        public double BaseDefense { get; set; }

        /// <summary>
        /// The combatant's defense against magical attacks
        /// </summary>
        public double MagicDefense { get; set; }

        /// <summary>
        /// The combatant's base magic defense before buffs
        /// </summary>
        public double BaseMagicDefense { get; set; }

        /// <summary>
        /// The combatant's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The class type of the combatant
        /// </summary>
        public string ClassType { get; set; }


        /// <summary>
        /// The primary currency used in the shop
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// The level of the combatant
        /// </summary>
        public int Level { get; set; }


        /// <summary>
        /// The experience points of the combatant
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// The amount of experience needed to level up.
        /// </summary>
        public int ExperienceToLevel { get; set; }

        /// <summary>
        /// The chance for your attack or spell to be a critical strike
        /// </summary>
        public double CriticalHitRate { get; set; }

        /// <summary>
        /// The combatant's base critical hit chance before buffs
        /// </summary>
        public double BaseCritChance { get; set; }


        /// <summary>
        /// The chance for your combatant to dodge an attack
        /// </summary>
        public double DodgeRate { get; set; }

        /// <summary>
        /// The combatant's base dodge rate before buffs
        /// </summary>
        public double BaseDodge { get; set; }

        public int SkillPoints { get; set; }

        public Dictionary<string, int> Inventory { get; set; }

        public Dictionary<string, string> Skills { get; set; }

        public int AbsorbAmount { get; set; }

        public Combatant(string name, string classType)
        {
            Name = name;
            ClassType = classType;
            Level = 1;
            Experience = 0;
            ExperienceToLevel = Level * 12;
            Inventory = new Dictionary<string, int>();
            Skills = new Dictionary<string, string>();
            Gold = 25;
            SkillPoints = 0;

        }

        public void EnemyTurn(Combatant hero, Combatant enemy)
        {
            Random random = new Random();
            CombatMethods.Attack(StoredCombatants.Enemy, StoredCombatants.Hero);

        }

    }

}



