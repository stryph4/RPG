using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Game.Classes;

namespace RPG.Windows
{
    /// <summary>
    /// Interaction logic for CharacterMenu.xaml
    /// </summary>
    public partial class CharacterMenu : Window
    {
        public CharacterMenu(Combatant hero)
        {
            InitializeComponent();
            PrintHero(hero);
        }

        public void PrintHero(Combatant hero)
        {
            nameLabel.Content = $"{hero.Name}";
            classLabel.Content = $"Class: {hero.ClassType}";
            levelLabel.Content = $"Level: {hero.Level}";
            healthLabel.Content = $"Health: {hero.HP} / {hero.MaxHP}";
            mpLabel.Content = $"MP: {hero.MP} / {hero.MaxMP}";
            experienceLabel.Content = $"Exp: {hero.Experience} / {hero.ExperienceToLevel}";
            strengthLabel.Content = $"Strength: {hero.Strength}";
            agilityLabel.Content = $"Agility: {hero.Agility}";
            intelligenceLabel.Content = $"Intelligence: {hero.Intelligence}";
            atkpwrLabel.Content = $"Attack Power: {hero.AttackPower}";
            splpwrLabel.Content = $"Spell Power: {hero.SpellPower}";
            defenseLabel.Content = $"Def: {hero.Defense}";
            magicDefenseLabel.Content = $"MDef: {hero.MagicDefense}";
            critLabel.Content = $"Crit %: {hero.CriticalHitRate}";
            dodgeLabel.Content = $"Dodge %: {hero.DodgeRate}";
        }
    }
}
