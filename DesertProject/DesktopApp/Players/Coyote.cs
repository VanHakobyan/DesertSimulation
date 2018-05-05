using DesktopApp.Base_classes;

namespace DesktopApp.Players
{
    public class Coyote : Element
    {
        public int Starvation { get; set; } = PlayerSettings.StarvationCoyote;
        public int Dehydration { get; set; } = PlayerSettings.DehydrationCoyote;
        public int Gestation { get; set; } = PlayerSettings.GestationCoyote;
        public int Lifetime { get; set; } = PlayerSettings.LifetimeCoyote;

        public Coyote()
        {
            ElementType = ElementType.Coyote;
            CountOnDesert = PlayerSettings.CountOnDesertCoyot;
            Name = "C";
        }
    }
}
