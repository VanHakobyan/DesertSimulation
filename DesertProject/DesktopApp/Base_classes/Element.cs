using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Base_classes
{
    public class Element
    {
        public ElementType ElementType { get; set; }
        public int CountOnMap { get; set; }
        public string Color { get; set; } = "peru";
    }
}
