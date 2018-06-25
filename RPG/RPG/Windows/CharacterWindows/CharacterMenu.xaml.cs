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
using RPG.Classes;

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
            WindowPositioner.CenterWindowOnScreen(this);
            HP_Bar.Maximum = hero.MaxHP;
            MP_Bar.Maximum = hero.MaxMP;
            HP_Bar.Minimum = 0;
            MP_Bar.Minimum = 0;
            HP_Bar.Value = hero.HP;
            MP_Bar.Value = hero.MP;
            PrintHero(hero);
            ShowHeroImage(hero);
            StoredCombatants.Hero = hero;
            CharacterMethods.InitializeInventoryAndSpells(StoredCombatants.Hero);


    }

        /// <summary>
        /// Sets labels of hero stats in the main menu
        /// </summary>
        /// <param name="hero"></param>
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
            goldLabel.Content = $"Gold: {hero.Gold}";
            skillPtsLabel.Content = $"Skill Pts: {hero.SkillPoints}";

            if (HP_Bar.Value < hero.HP / 4)
            {
                HP_Bar.Foreground = Brushes.Red;
            }
            if (HP_Bar.Value < hero.HP / 2)
            {
                HP_Bar.Foreground = Brushes.Yellow;
            }
        }

        public void ShowHeroImage(Combatant hero)
        {
            ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/" + hero.ClassType + ".png", UriKind.Relative));

        }

        private void Explore_Click(object sender, RoutedEventArgs e)
        {
            ExploreWindow exploreWindow = new ExploreWindow(StoredCombatants.Hero);
            exploreWindow.ShowDialog();

        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Skill_Click(object sender, RoutedEventArgs e)
        {

        }



    }
}
