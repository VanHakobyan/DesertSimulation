using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Base_classes
{
    public class Element
    {
        public int CountOnDesert { get; set; }
        public ElementType ElementType { get; set; }
        public string Color { get; set; } = "peru";
        public string Name { get; set; } = "";
    }
}
