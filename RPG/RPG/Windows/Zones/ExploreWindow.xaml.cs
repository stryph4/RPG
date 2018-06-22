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
    /// Interaction logic for ExploreWindow.xaml
    /// </summary>
    public partial class ExploreWindow : Window
    {
        public ExploreWindow(Combatant hero)
        {
            InitializeComponent();
            zoneSelector.Items.Add("Forest");
            
        }

        private void Okay_Button_Clicked(object sender, RoutedEventArgs e)
        {
            if (zoneSelector.SelectedIndex == 0)
            {
                ForestExplore forestExplore = new ForestExplore();
                forestExplore.ShowDialog();

                Close();
            }
        }

        private void Cancel_Button_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
