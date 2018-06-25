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

            foreach (var kvp in StoredCombatants.Hero.Inventory)
            {
                ItemBox.Items.Add(kvp.Key.PadRight(10) + "Qty: " + kvp.Value);
            }

            foreach (var kvp in StoredCombatants.Hero.Skills)
            {
                SkillBox.Items.Add(kvp.Key);
            }

            HP_Bar.Maximum = StoredCombatants.Hero.MaxHP;
            HP_Bar.Minimum = 0;
            HP_Bar.Value = StoredCombatants.Hero.HP;
            MP_Bar.Maximum = StoredCombatants.Hero.MaxMP;
            MP_Bar.Minimum = 0;
            MP_Bar.Value = StoredCombatants.Hero.MP;


        }

        public void ShowHeroImage()
        {
            ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/" + StoredCombatants.Hero.ClassType + ".png", UriKind.Relative));
        }

        private void Attack_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Item_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ItemBox.SelectedIndex.ToString().Contains("Potion"))
            {

            }
        }

        private void Skill_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HP_Bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}

