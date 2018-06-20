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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            QuitWindow quitWindow = new QuitWindow();
            quitWindow.Show();
        }

        private void New_Game_Click(object sender, RoutedEventArgs e)
        {
            
            CreateNewCharacter characterWindow = new CreateNewCharacter();
            characterWindow.Show();
            Close();
        }
    }
}
