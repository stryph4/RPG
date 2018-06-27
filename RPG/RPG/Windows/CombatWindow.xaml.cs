using RPG.Classes;
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
using System.Threading;

namespace RPG.Windows
{
    /// <summary>
    /// Interaction logic for CombatWindow.xaml
    /// </summary>
    public partial class CombatWindow : Window
    {
        public CombatWindow()
        {

            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
            ShowHeroImage();
            ShowEnemyimage();

            foreach (var kvp in StoredCombatants.Hero.Inventory)
            {
                ItemBox.Items.Add(kvp.Key.PadRight(10) + "Qty: " + kvp.Value);
            }

            foreach (var kvp in StoredCombatants.Hero.Skills)
            {
                SkillBox.Items.Add(kvp.Key);
            }

            UpdateHPAndMP();
            hero_HP_Bar.Maximum = StoredCombatants.Hero.MaxHP;
            hero_HP_Bar.Minimum = 0;
            hero_HP_Bar.Value = StoredCombatants.Hero.HP;
            hero_MP_Bar.Maximum = StoredCombatants.Hero.MaxMP;
            hero_MP_Bar.Minimum = 0;
            hero_MP_Bar.Value = StoredCombatants.Hero.MP;
            enemy_HP_Bar.Maximum = StoredCombatants.Enemy.MaxHP;
            enemy_HP_Bar.Minimum = 0;
            enemy_HP_Bar.Value = StoredCombatants.Enemy.HP;
            enemy_MP_Bar.Maximum = StoredCombatants.Enemy.MaxMP;
            enemy_MP_Bar.Minimum = 0;
            enemy_MP_Bar.Value = StoredCombatants.Enemy.MP;


        }

        private void UpdateHPAndMP()
        {
            hero_Health.Content = $"HP: {StoredCombatants.Hero.HP} / {StoredCombatants.Hero.MaxHP}";
            hero_MP.Content = $"MP: {StoredCombatants.Hero.MP} / {StoredCombatants.Hero.MaxMP}";
            enemy_Health.Content = $"HP: {StoredCombatants.Enemy.HP} / {StoredCombatants.Enemy.MaxHP}";
            enemy_MP.Content = $"MP: {StoredCombatants.Enemy.MP} / {StoredCombatants.Enemy.MaxMP}";
            hero_HP_Bar.Value = StoredCombatants.Hero.HP;
            hero_MP_Bar.Value = StoredCombatants.Hero.MP;
            enemy_HP_Bar.Value = StoredCombatants.Enemy.HP;
            enemy_MP_Bar.Value = StoredCombatants.Enemy.MP;
            enemy_Health.Content = $"HP: {StoredCombatants.Enemy.HP} / {StoredCombatants.Enemy.MaxHP}";
            enemy_MP.Content = $"MP: {StoredCombatants.Enemy.MP} / {StoredCombatants.Enemy.MaxMP}";
            if (hero_HP_Bar.Value < StoredCombatants.Hero.HP / 4)
            {
                hero_HP_Bar.Foreground = Brushes.Red;
            }
            if (hero_HP_Bar.Value <= StoredCombatants.Hero.HP / 2)
            {
                hero_HP_Bar.Foreground = Brushes.Yellow;
            }

            if (enemy_HP_Bar.Value <= StoredCombatants.Enemy.HP / 4)
            {
                enemy_HP_Bar.Foreground = Brushes.Red;
            }
            if (enemy_HP_Bar.Value <= StoredCombatants.Enemy.HP / 2)
            {
                enemy_HP_Bar.Foreground = Brushes.Yellow;
            }
        }

        private void PrintCombatLog()
        {
            CombatLog.Text = String.Empty;
            foreach (var item in CombatMethods.combatLog)
            {
                CombatLog.Text += item;
                CombatLog.Text += Environment.NewLine;
                CombatLog.Text += Environment.NewLine;
            }
        }

        public void ShowHeroImage()
        {
            ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/" + StoredCombatants.Hero.ClassType + ".png", UriKind.Relative));
        }

        public void ShowEnemyimage()
        {
            EnemyImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/" + StoredCombatants.Enemy.Name + ".png", UriKind.Relative));
        }

        private void Attack_Button_Click(object sender, RoutedEventArgs e)
        {
            CombatMethods.Attack(StoredCombatants.Hero, StoredCombatants.Enemy);
            UpdateHPAndMP();
            PrintCombatLog();

            if (StoredCombatants.Enemy.HP <= 0)
            {
                CombatMethods.EndCombat(StoredCombatants.Hero, StoredCombatants.Enemy);
                CharacterMenu characterMenu = new CharacterMenu(StoredCombatants.Hero);
                characterMenu.Show();
                Close();
            }

            StoredCombatants.Enemy.EnemyTurn(StoredCombatants.Hero, StoredCombatants.Enemy);
            UpdateHPAndMP();
            PrintCombatLog();

            if (StoredCombatants.Hero.HP <= 0)
            {
                CombatMethods.GameOver();
            }

        }

        private void Item_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ItemBox.SelectedIndex.ToString().Contains("Potion"))
            {
                Items.UsePotion(StoredCombatants.Hero);
            }
        }

        private void Skill_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hero_HP_Bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Hero_MP_Bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Enemy_HP_Bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Enemy_MP_Bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}

