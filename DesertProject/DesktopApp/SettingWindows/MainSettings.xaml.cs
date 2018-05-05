﻿using System;
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
            Init();
        }

        private void Init()
        {
            CoyotesCount.Text = "3";
            ObstaclesCount.Text = "5";
            PatchesOfGrassCount.Text = "4";
            PocketMiceCount.Text = "2";
            QuicksandSinkholesCount.Text = "14";
            WaterSourcesCount.Text = "4";
            Height.Text = "15";
            Width.Text = "20";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Height.Text, out var x);
            int.TryParse(Width.Text, out var y);
            int.TryParse(CoyotesCount.Text, out var coyotesCount);
            int.TryParse(ObstaclesCount.Text, out var obstaclesCount);
            int.TryParse(PatchesOfGrassCount.Text, out var patchesOfGrassCount);
            int.TryParse(PocketMiceCount.Text, out var pocketMiceCount);
            int.TryParse(QuicksandSinkholesCount.Text, out var quicksandSinkholesCount);
            int.TryParse(WaterSourcesCount.Text, out var waterSourcesCount);
            
            if (x != default(int) && y != default(int))
            {
               // ConfigurationManager.AppSettings["YourKey"] = $"{x},{y}";
                new MainViewModel(x, y).Show();
            }
            else MessageBox.Show("Please enter correct!!!");
            
            Close();

        }
    }
}
