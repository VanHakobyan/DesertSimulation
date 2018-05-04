using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainSetings.xaml
    /// </summary>
    public partial class MainSetings : Window
    {
        public MainSetings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int.TryParse(Height.Text, out var x);
            int.TryParse(Width.Text, out var y);
            if (x != default(int) && y != default(int))
            {
                ConfigurationManager.AppSettings["YourKey"] = $"{x},{y}";
                new MainViewModel(x, y).Show();
            }
            else MessageBox.Show("Please enter correct!!!");
            Close();

        }
    }
}
