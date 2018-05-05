using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Base_classes.Elements
{
    public class Quicksand : Element
    {
        public Quicksand()
        {
            ElementType = ElementType.Quicksand;
            Color = "yellow";
            CountOnDesert = MainSettings.QuicksandSinkholesCount;
        }
    }
}
