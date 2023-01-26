using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
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
using Path = System.IO.Path;

namespace SoloAdventureToolkit
{
    /// <summary>
    /// Interaction logic for AddThings.xaml
    /// </summary>
    public partial class AddThings : UserControl
    {
        public DataContext _dataContext = new DataContext();

        public AddThings()
        {
            InitializeComponent();
        }

        private void AddFirstName_Click(object sender, RoutedEventArgs e)
        {
            string newName = FirstName.Text;
            
            //var path = Path.Combine(Environment.SpecialFolder.ApplicationData, "")
            //var sr = new StreamWriter(stream:)
        }
    }
}
