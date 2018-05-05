using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DesktopApp.Base_classes.Elements
{
    public class Water : Element
    {
        public Water()
        {
            ElementType = ElementType.Water;
            Color = "blue";
            CountOnDesert = MainSettingsModel.WaterSourcesCount;
        }
    }
}
