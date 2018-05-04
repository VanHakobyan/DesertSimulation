using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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
            CreteRectangle(10, 20);
            PositionSetter();
        }

        private void PositionSetter()
        {
            for (int i = 0; i < RectangleGrid.Children.Count; i++)
            {
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        private void CreteRectangle(int height, int width)
        {
            for (var i = 1; i < height; i++)
            {
                var rectangle = new Rectangle
                {
                    Height = 10*i,
                    Width = 10*i
                };
                var blueBrush = new SolidColorBrush {Color = Colors.Blue};
                var blackBrush = new SolidColorBrush {Color = Colors.Black};

                // Set Rectangle's width and color
                rectangle.StrokeThickness = 4;
                rectangle.Stroke = blackBrush;

                // Fill rectangle with blue color
                rectangle.Fill = blueBrush;
                RectangleGrid.Children.Add(rectangle);
            }
        }
    }
}
