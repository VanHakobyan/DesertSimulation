using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApp.Base_classes;

namespace DesktopApp.Players
{
    public class Coyote : Element
    {
        public int Starvation { get; set; } = 30;
        public int Dehydration { get; set; } = 50;
        public int Gestation { get; set; } = 100;
        public int Lifetime { get; set; } = 200;

        public Coyote()
        {
            ElementType = ElementType.Coyote;
            CountOnDesert = 1;
            Name = "Coyote";
        }
    }
}
