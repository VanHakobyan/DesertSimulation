﻿using System;
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
using System.Windows.Shapes;
using System.Xml;
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
            if (!File.Exists("PlayerSettings.xml"))
            {
                StarvationCoyote.Text = "30";
                DehydrationCoyote.Text = "50";
                GestationCoyote.Text = "100";
                LifetimeCoyote.Text = "200";
                StarvationPocket.Text = "30";
                DehydrationPocket.Text = "50";
                GestationPocket.Text = "100";
                LifetimePocket.Text = "200";
                CountOnDesertCoyote.Text = "1";
                CountOnDesertPocket.Text = "1";
            }
            else
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                var fs = new FileStream("PlayerSettings.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                StarvationCoyote.Text = xmldoc.ChildNodes[1].ChildNodes[0].InnerText;
                DehydrationCoyote.Text = xmldoc.ChildNodes[1].ChildNodes[1].InnerText;
                GestationCoyote.Text = xmldoc.ChildNodes[1].ChildNodes[2].InnerText;
                LifetimeCoyote.Text = xmldoc.ChildNodes[1].ChildNodes[3].InnerText;
                StarvationPocket.Text = xmldoc.ChildNodes[1].ChildNodes[4].InnerText;
                DehydrationPocket.Text = xmldoc.ChildNodes[1].ChildNodes[5].InnerText;
                GestationPocket.Text = xmldoc.ChildNodes[1].ChildNodes[6].InnerText;
                LifetimePocket.Text = xmldoc.ChildNodes[1].ChildNodes[7].InnerText;
                CountOnDesertCoyote.Text= xmldoc.ChildNodes[1].ChildNodes[8].InnerText;
                CountOnDesertPocket.Text= xmldoc.ChildNodes[1].ChildNodes[9].InnerText;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            using (XmlWriter writer = XmlWriter.Create("PlayerSettings.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("MainSetting");

                writer.WriteElementString("StarvationCayote", StarvationCoyote.Text);
                writer.WriteElementString("DehydrationCayote", DehydrationCoyote.Text);
                writer.WriteElementString("GestationCayote", GestationCoyote.Text);
                writer.WriteElementString("LifetimeCayote", LifetimeCoyote.Text);
                writer.WriteElementString("StarvationPocket", StarvationPocket.Text);
                writer.WriteElementString("DehydrationPocket", DehydrationPocket.Text);
                writer.WriteElementString("GestationPocket", GestationPocket.Text);
                writer.WriteElementString("LifetimePocket", LifetimePocket.Text);
                writer.WriteElementString("CountOnDesertCoyote", CountOnDesertCoyote.Text);
                writer.WriteElementString("CountOnDesertPocket", CountOnDesertPocket.Text);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            MainWindow.Restart();
            //int.TryParse(StarvationCayote.Text,out var cayoteStarvation);
            //int.TryParse(DehydrationCayote.Text,out var cayoteDehydration);
            //int.TryParse(GestationCayote.Text,out var cayoteGestation);
            //int.TryParse(LifetimeCayote.Text, out var cayoteLifetime);

            //var cayote = new Coyote();

            //if (cayoteStarvation != 0) cayote.Starvation = cayoteStarvation;
            //if (cayoteDehydration != 0) cayote.Dehydration= cayoteDehydration;
            //if (cayoteGestation != 0) cayote.Gestation= cayoteGestation;
            //if (cayoteLifetime!= 0) cayote.Lifetime= cayoteLifetime;

            //int.TryParse(StarvationPocket.Text, out var pocketStarvation);
            //int.TryParse(DehydrationPocket.Text, out var pocketDehydration);
            //int.TryParse(GestationPocket.Text, out var pocketGestation);
            //int.TryParse(LifetimePocket.Text, out var pocketLifetime);

            //var pocket=new PocketMouse();

            //if (pocketDehydration!= 0) pocket.Dehydration= pocketDehydration;
            //if (pocketGestation!= 0) pocket.Gestation= pocketGestation;
            //if (pocketLifetime!= 0) pocket.Lifetime= pocketLifetime;
            //if (pocketStarvation!= 0) pocket.Starvation= pocketStarvation;
        }
    }
}
