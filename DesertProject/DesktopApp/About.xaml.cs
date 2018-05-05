using System.Windows;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
            TextBlock.Text = "Coyotes and pocket mice have lifetimes after which they would die and hence\r\nno longer exist in the desert. The lifetime indicates the number of iterations\r\nthat the animal can pass through before dying of natural causes.\r\nCoyotes and pocket mice also have a starvation period, which indicates the\r\nnumber of iterations that the animal can pass through without eating before it\r\ndies. Similarly, animals have a dehydration period that they cannot exceed\r\nwithout drinking. When an animal dies, it is replaced by an empty space.\r\nCoyotes and pocket mice also have different gestation periods (number of\r\niterations) after which they will give birth to new coyotes and pocket mice.\r\nWhen the end of a gestation period is reached, a new animal shall be created.\r\nThe newborn animal shall be randomly placed in one of the eight neighboring\r\ncells. If none of these cells are empty, the newborn would die.";
        }
    }
}
