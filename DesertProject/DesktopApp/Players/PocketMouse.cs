using DesktopApp.Base_classes;

namespace DesktopApp.Players
{
    public class PocketMouse : Element
    {
        public int Starvation { get; set; } = PlayerSettings.StarvationPocket;
        public int Dehydration { get; set; } = PlayerSettings.DehydrationPocket;
        public int Gestation { get; set; } = PlayerSettings.GestationPocket;
        public int Lifetime { get; set; } = PlayerSettings.LifetimePocket;

        public PocketMouse()
        {
            ElementType = ElementType.PocketMouse;
            CountOnDesert = PlayerSettings.CountOnDesertPocket;
            Name = "PM";
        }
    }
}
