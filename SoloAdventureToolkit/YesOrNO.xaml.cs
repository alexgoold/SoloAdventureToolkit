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
    /// Interaction logic for YesOrNO.xaml
    /// </summary>
    public partial class YesOrNO : UserControl
    {
        public YesOrNO()
        {
            InitializeComponent();
        }
        private void YesOrNo_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is not Button button) return;

            var d20 = new Random();
            var answer = d20.Next(1, 21);
            var modifier = 0;
            var rollInfo = button.Content.ToString();
            YesOrNo.FontSize = 48;
            switch (button.Name)
            {
                case "Impossible":
                    modifier = -6;
                    rollInfo += $" {answer}-6)";
                    break;
                case "HighlyUnlikely":
                    modifier = -4;
                    rollInfo += $" {answer}-4)";
                    break;
                case "Unlikely":
                    modifier = -2;
                    rollInfo += $" {answer}-2)";
                    break;
                case "Possible":
                    rollInfo += $" {answer}+0";
                    break;
                case "Likely":
                    modifier = +2;
                    rollInfo += $" {answer}+2)";
                    break;
                case "HighlyLikely":
                    modifier = +4;
                    rollInfo += $" {answer}+4)";
                    break;
                case "ACertainty":
                    modifier = +6;
                    rollInfo += $" {answer}+6)";
                    break;
            }
            if (answer + modifier < 7)
            {
                YesOrNo.Text = "NO";
                YesNoResults.Text += $"NO    {answer + modifier} ({rollInfo})\n";
            }
            else if (answer + modifier is > 6 and < 13)
            {
                YesOrNo.FontSize -= 8;
                YesOrNo.Text = "MAYBE";
                YesNoResults.Text += $"MAYBE     {answer + modifier} ({rollInfo})\n";

            }
            else
            {
                YesOrNo.Text = "YES";
                YesNoResults.Text += $"YES   {answer + modifier} ({rollInfo})\n";

            }
        }

        private void ClearYesNo_OnClick_Click(object sender, RoutedEventArgs e)
        {
            YesNoResults.Text = String.Empty;
            YesOrNo.Text = String.Empty;
        }
    }
}

