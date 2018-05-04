using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Base_classes.Elements
{
    public class Rock : Element
    {
        public Rock()
        {
            ElementType = ElementType.Rock;
            Color = "black";
            CountOnDesert = 5;
        }
    }
}
