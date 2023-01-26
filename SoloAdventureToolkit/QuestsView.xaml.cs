using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for QuestsView.xaml
    /// </summary>
    public partial class QuestsView : UserControl
    {

        public DataContext _dataContext = new DataContext();
        
        public QuestsView()
        {
            InitializeComponent();
        }


        private void GenerateQuest_Click(object sender, RoutedEventArgs e)
        {
            var problemIndex = new Random().Next(0, 25);
            var sourceIndex = new Random().Next(0, 32);
            QuestOutput.Text += $"\n{_dataContext.Results[problemIndex]}\n\n\n";
            ProblemOutput.Text += $"\n{_dataContext.Problems[problemIndex]}\n\n\n";
            SourceOutput.Text += $"\n{_dataContext.Source[sourceIndex]}\n\n\n";

        }

        private void ClearText_Click(object sender, RoutedEventArgs e)
        {
            QuestOutput.Text = String.Empty;
            ProblemOutput.Text = String.Empty;
            SourceOutput.Text = String.Empty;
        }

        private void Verb_OnClick_Click(object sender, RoutedEventArgs e)
        {
            var verb = new Random().Next(0, 499);
            Verb.Text += _dataContext.Verbs[verb] + "\n";
        }

        private void Clear_Verb_OnClickVerb_Click(object sender, RoutedEventArgs e)
        {
            Verb.Text = String.Empty;
        }
    }
}
