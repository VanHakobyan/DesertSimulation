using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Base_classes.Elements
{
    public class Water : Element
    {
        public Water()
        {
            ElementType = ElementType.Water;
            Color = "blue";
            CountOnMap = 4;
        }
    }
}
