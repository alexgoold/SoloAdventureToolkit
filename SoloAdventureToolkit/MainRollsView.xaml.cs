using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
    /// Interaction logic for MainRollsView.xaml
    /// </summary>
    public partial class MainRollsView : UserControl
    {
        DataContext _dataContext = new DataContext();

        public MainRollsView()
        {
            InitializeComponent();
        }

        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is not Button button) return;
            int diceMax = int.Parse(button.Name.Remove(0, 1));
            var DiceRandom = new Random();
            var result = DiceRandom.Next(1, diceMax + 1);
            int modifier = 0;
            switch (button.Name)
            {
                case "d4":
                    if (int.TryParse(d4Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d6":
                    if (int.TryParse(d6Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d8":
                    if (int.TryParse(d8Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d10":
                    if (int.TryParse(d10Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d12":
                    if (int.TryParse(d12Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d20":
                    if (int.TryParse(d20Modifier.Text, out modifier))
                    {
                    }

                    break;
                case "d100":
                    if (int.TryParse(d100Modifier.Text, out modifier))
                    {
                    }

                    break;
            }

            _dataContext.Result = result;
            button.DataContext = (result + modifier);
            DiceRollResults.Text += $"{result + modifier} ({result} + {modifier})\n";
        }

        private void ClearScrollView_Click(object sender, RoutedEventArgs e)
        {
            DiceRollResults.Text = String.Empty;
            d4Result.Text = String.Empty;
            d6Result.Text = String.Empty;
            d8Result.Text = String.Empty;
            d10Result.Text = String.Empty;
            d12Result.Text = String.Empty;
            d20Result.Text = String.Empty;
            d100Result.Text = String.Empty;
        }

    }
}
