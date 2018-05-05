namespace DesktopApp.Base_classes.Elements
{
    public class Grass : Element
    {
        public Grass()
        {
            ElementType = ElementType.Grass;
            Color = "green";
            CountOnDesert = MainSettingsModel.PatchesOfGrassCount;
        }
    }
}
