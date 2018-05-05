using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
