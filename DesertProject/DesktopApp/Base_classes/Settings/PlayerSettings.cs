namespace DesktopApp.Base_classes
{
    public static class PlayerSettings
    {
        public static int StarvationCoyote { get; set; } = 30;
        public static int DehydrationCoyote { get; set; } = 50;
        public static int GestationCoyote { get; set; } = 100;
        public static int LifetimeCoyote { get; set; } = 200;
        public static int StarvationPocket { get; set; } = 30;
        public static int DehydrationPocket { get; set; } = 50;
        public static int GestationPocket { get; set; } = 100;
        public static int LifetimePocket { get; set; } = 200;
        public static int CountOnDesertPocket { get; set; } = 1;
        public static int CountOnDesertCoyot { get; set; } = 1;
        public static int GestationPeriod { get; set; } = 3;
    }
}
