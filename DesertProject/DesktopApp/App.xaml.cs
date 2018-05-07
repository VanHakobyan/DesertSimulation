using System.Windows;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainViewModel viewModel;
        public void Call() => OnStartup(null);
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            viewModel = new MainViewModel();
            viewModel.Show();
        }
    }
}
