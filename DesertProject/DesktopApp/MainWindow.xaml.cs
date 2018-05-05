using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers.Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //
        }

        public static Application GetApp()
        {
            return Application.Current;
        }
        private void MenuExit_OnClick(object sender, RoutedEventArgs e) => Close();

        private void MenuRestart_OnClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void PlayerSettings_OnClick(object sender, RoutedEventArgs e) => new Settings().Show();

        private void Pause_OnClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Play_OnClick(object sender, RoutedEventArgs e)
        {
          timer.Start();
        }

        private void About_OnClick(object sender, RoutedEventArgs e)=>new About().Show();

        private void MainSettings_OnClick(object sender, RoutedEventArgs e) => new MainSetings().Show();
    }
}
