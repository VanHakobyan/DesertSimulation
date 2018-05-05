using System;
using System.Collections.Generic;
using System.Configuration;
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
            Init();
        }

        private void Init()
        {
            if (!File.Exists("MainSettings.xml"))
            {
                Height.Text = "15";
                Width.Text = "20";
                CoyotesCount.Text = "3";
                ObstaclesCount.Text = "5";
                PatchesOfGrassCount.Text = "4";
                PocketMiceCount.Text = "2";
                QuicksandSinkholesCount.Text = "14";
                WaterSourcesCount.Text = "4";
            }
            else
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                FileStream fs = new FileStream("MainSettings.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                Height.Text = xmldoc.ChildNodes[1].ChildNodes[0].InnerText;
                Width.Text = xmldoc.ChildNodes[1].ChildNodes[1].InnerText;
                PatchesOfGrassCount.Text = xmldoc.ChildNodes[1].ChildNodes[2].InnerText;
                CoyotesCount.Text = xmldoc.ChildNodes[1].ChildNodes[3].InnerText;
                ObstaclesCount.Text = xmldoc.ChildNodes[1].ChildNodes[4].InnerText;
                PocketMiceCount.Text = xmldoc.ChildNodes[1].ChildNodes[5].InnerText;
                QuicksandSinkholesCount.Text = xmldoc.ChildNodes[1].ChildNodes[6].InnerText;
                WaterSourcesCount.Text = xmldoc.ChildNodes[1].ChildNodes[7].InnerText;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int.TryParse(Height.Text, out var x);
            //int.TryParse(Width.Text, out var y);
            //int.TryParse(CoyotesCount.Text, out var coyotesCount);
            //int.TryParse(ObstaclesCount.Text, out var obstaclesCount);
            //int.TryParse(PatchesOfGrassCount.Text, out var patchesOfGrassCount);
            //int.TryParse(PocketMiceCount.Text, out var pocketMiceCount);
            //int.TryParse(QuicksandSinkholesCount.Text, out var quicksandSinkholesCount);
            //int.TryParse(WaterSourcesCount.Text, out var waterSourcesCount);

            using (XmlWriter writer = XmlWriter.Create("MainSettings.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("MainSetting");

                writer.WriteElementString("Height", Height.Text);
                writer.WriteElementString("Width", Width.Text);
                writer.WriteElementString("PatchesOfGrassCount", PatchesOfGrassCount.Text);
                writer.WriteElementString("CoyotesCount", CoyotesCount.Text);
                writer.WriteElementString("ObstaclesCount", ObstaclesCount.Text);
                writer.WriteElementString("PocketMiceCount", PocketMiceCount.Text);
                writer.WriteElementString("PocketMiceCount", QuicksandSinkholesCount.Text);
                writer.WriteElementString("WaterSourcesCount", WaterSourcesCount.Text);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            XmlDataDocument xmldoc = new XmlDataDocument();
            FileStream fs = new FileStream("MainSettings.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            new MainViewModel().Show();
            Close();

        }
    }
}
