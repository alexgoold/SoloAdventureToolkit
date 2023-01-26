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

namespace SoloAdventureToolkit
{
    /// <summary>
    /// Interaction logic for NPCView.xaml
    /// </summary>
    public partial class NPCView : UserControl
    {
        private DataContext _dataContext = new DataContext();
        public NPCView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string output = String.Empty;
            var firstNameIndex = new Random().Next(0, 371);
            var lastNameIndex = new Random().Next(0, 435);
            output += $"Name: { _dataContext.FirstName[firstNameIndex]} {_dataContext.LastName[lastNameIndex]}\n";
            var raceIndex = new Random().Next(0, 59);
            var Race = _dataContext.Race[raceIndex];
            output += $"Race: {_dataContext.Race[raceIndex]}\n";
            var ageIndex = new Random().Next(15, 101);
            if (Race.Contains("Dwarf") ||Race.Contains("Duergar"))
            {
                output += $"Age: {ageIndex*4}\n";
            }
            else if (Race.Contains("Elf") || Race.Contains("Eladrin") || Race.Contains("Drow") && !Race.Contains("Half Elf"))
            {
                output += $"Age: {ageIndex*6}\n";

            }
            else if (Race.Contains("Half Elf"))
            {
                output += $"Age: {ageIndex * 3}\n";
            }
            else
            {
                output += $"Age: {ageIndex}\n";
            }
            var alignmentIndex = new Random().Next(0, 24);
            output += $"Alignment: {_dataContext.Alignment[alignmentIndex]}\n";
            var gender = new Random().Next(1, 4);
            string sex = String.Empty;
            switch (gender)
            {
                case 1:
                    sex = "Male";
                    break;
                case 2:
                    sex = "Female";
                    break;
                case 3:
                    sex = "Other";
                    break;
            }
            output += $"Sex: {sex}\n";
            var commonerOrNot = new Random().Next(1, 7);
            var profession = new Random().Next(0, 30);
            if (commonerOrNot <= 2)
            {
                output += $"Profession: Commoner\n";
            }
            else if (commonerOrNot >= 6)
            {
                output += $"Profession: Adventurer\n";
            }
            else
            {
                output += $"Profession: {_dataContext.Profession[profession]}\n";
            }

            var disposition = new Random().Next(0, 39);
            output += $"Disposition: {_dataContext.Disposition[disposition]}\n";
            var economicStatus = new Random().Next(0, 21);
            output += $"Economic Status: {_dataContext.EconomicStatus[economicStatus]}\n";
            NpcInfo.Text += output+"\n\n";
            //var image = new Image();
            //Uri resourceUri = new Uri("Resources/EpicQuest.png", UriKind.Relative);
            //image.Source = new BitmapImage(resourceUri);
            //Background.Source = image.Source;
            //  This will load the image from resources! WHEN YOU CLICK THE BUTTON!! 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NpcInfo.Text = String.Empty;
        }
    }
}
