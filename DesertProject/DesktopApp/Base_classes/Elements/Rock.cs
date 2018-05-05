namespace DesktopApp.Base_classes.Elements
{
    public class Rock : Element
    {
        public Rock()
        {
            ElementType = ElementType.Rock;
            Color = "black";
            CountOnDesert = MainSettings.ObstaclesCount;
        }
    }
}
