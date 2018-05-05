namespace DesktopApp.Base_classes.Elements
{
    public class Quicksand : Element
    {
        public Quicksand()
        {
            ElementType = ElementType.Quicksand;
            Color = "yellow";
            CountOnDesert = MainSettingsModel.QuicksandSinkholesCount;
        }
    }
}
