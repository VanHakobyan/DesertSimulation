using System.Windows;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        public static void Restart()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void PlayerSettings_OnClick(object sender, RoutedEventArgs e)
        {
            Pause_OnClick(null,null);
            new Settings().Show();
        }

        #region Game settings handlers
        private void Pause_OnClick(object sender, RoutedEventArgs e)
        {
            MainViewModel.timer.Enabled = false;
        }
        private void Play_OnClick(object sender, RoutedEventArgs e)
        {
            MainViewModel.timer.Start();
        }
        private void Resume_OnClick(object sender, RoutedEventArgs e)
        {
            MainViewModel.timer.Enabled = true;
        }
        #endregion

        private void About_OnClick(object sender, RoutedEventArgs e)
        {
            Pause_OnClick(null,null);
            new About().Show();
        }

        private void MainSettings_OnClick(object sender, RoutedEventArgs e)
        {
            Pause_OnClick(null, null);
            new MainSettings().Show();
        }
    }
}
