using Game.Classes;
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
    /// Interaction logic for ForestExplore.xaml
    /// </summary>
    public partial class ForestExplore : Window
    {
        public ForestExplore()
        {
            InitializeComponent();
        }

        private void Leave_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Explore_Clicked(object sender, RoutedEventArgs e)
        {

        }

        public void ShowHeroImage(Combatant hero)
        {
            ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/" + hero.ClassType + ".png", UriKind.Relative));

        }
    }
}
