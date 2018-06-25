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
using RPG.Windows;


namespace RPG
{
    /// <summary>
    /// Interaction logic for CreateNewCharacter.xaml
    /// </summary>
    public partial class CreateNewCharacter : Window
    {

        bool showClassImage = false;

        public CreateNewCharacter()
        {

            InitializeComponent();
            ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/Warrior.png", UriKind.Relative));
            showClassImage = true;
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void Okay_Button_Click(object sender, RoutedEventArgs e)
        {
                CharacterMethods.Name = NameCharacter.Text;
                CharacterMenu characterMenu = new CharacterMenu(CharacterMethods.CreateCharacter());
                characterMenu.Show();
                Close();

        }

        private void mageButton_Checked(object sender, RoutedEventArgs e)
        {
            if (showClassImage == true)
            {

                ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/Mage.png", UriKind.Relative));
            }

            CharacterMethods.WarriorSelected = false;
            CharacterMethods.ThiefSelected = false;
            CharacterMethods.MageSelected = true;
            CharacterMethods.PaladinSelected = false;
        }

        private void paladinButton_Checked(object sender, RoutedEventArgs e)
        {
            if (showClassImage == true)
            {

                ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/Paladin.png", UriKind.Relative));
            }

            CharacterMethods.WarriorSelected = false;
            CharacterMethods.ThiefSelected = false;
            CharacterMethods.MageSelected = false;
            CharacterMethods.PaladinSelected = true;
        }

        private void thiefButton_Checked(object sender, RoutedEventArgs e)
        {
            if (showClassImage == true)
            {

                ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/Thief.png", UriKind.Relative));
            }

            CharacterMethods.WarriorSelected = false;
            CharacterMethods.ThiefSelected = true;
            CharacterMethods.MageSelected = false;
            CharacterMethods.PaladinSelected = false;
        }

        private void warriorButton_Checked(object sender, RoutedEventArgs e)
        {
            if (showClassImage == true)
            {

                ClassImage.Source = new BitmapImage(new Uri("/RPG;component/Sprites/Warrior.png", UriKind.Relative));
            }

            CharacterMethods.WarriorSelected = true;
            CharacterMethods.ThiefSelected = false;
            CharacterMethods.MageSelected = false;
            CharacterMethods.PaladinSelected = false;
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            CharacterMethods.Name = NameCharacter.Text;
            CharacterMenu characterMenu = new CharacterMenu(CharacterMethods.CreateCharacter());
            characterMenu.Show();
            Close();
        }
    }
}

