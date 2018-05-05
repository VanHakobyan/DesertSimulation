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
using System.Windows.Shapes;
using DesktopApp.Players;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            StarvationCayote.Text = "30";
            DehydrationCayote.Text = "50";
            GestationCayote.Text = "100";
            LifetimeCayote.Text = "200";
            StarvationPocket.Text = "30";
            DehydrationPocket.Text = "50";
            GestationPocket.Text = "100";
            LifetimePocket.Text = "200";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(StarvationCayote.Text,out var cayoteStarvation);
            int.TryParse(DehydrationCayote.Text,out var cayoteDehydration);
            int.TryParse(GestationCayote.Text,out var cayoteGestation);
            int.TryParse(LifetimeCayote.Text, out var cayoteLifetime);

            var cayote = new Coyote();

            if (cayoteStarvation != 0) cayote.Starvation = cayoteStarvation;
            if (cayoteDehydration != 0) cayote.Dehydration= cayoteDehydration;
            if (cayoteGestation != 0) cayote.Gestation= cayoteGestation;
            if (cayoteLifetime!= 0) cayote.Lifetime= cayoteLifetime;

            


            int.TryParse(StarvationPocket.Text, out var pocketStarvation);
            int.TryParse(DehydrationPocket.Text, out var pocketDehydration);
            int.TryParse(GestationPocket.Text, out var pocketGestation);
            int.TryParse(LifetimePocket.Text, out var pocketLifetime);

            var pocket=new PocketMouse();

            if (pocketDehydration!= 0) pocket.Dehydration= pocketDehydration;
            if (pocketGestation!= 0) pocket.Gestation= pocketGestation;
            if (pocketLifetime!= 0) pocket.Lifetime= pocketLifetime;
            if (pocketStarvation!= 0) pocket.Starvation= pocketStarvation;
        }
    }
}
