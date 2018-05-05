using DesktopApp.Base_classes;

namespace DesktopApp.Players
{
    public class PocketMouse : Element
    {
        public int Starvation { get; set; } = 30;
        public int Dehydration { get; set; } = 50;
        public int Gestation { get; set; } = 100;
        public int Lifetime { get; set; } = 200;

        public PocketMouse()
        {
            ElementType = ElementType.PocketMouse;
            CountOnDesert = 2;
            Name = "Pocket mouse";
        }
    }
}
