using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Players
{
    public class PlayerBase
    {
        public int Starvation { get; set; } = 30;
        public int Dehydration { get; set; } = 50;
        public int Gestation { get; set; } = 100;
        public int Lifetime { get; set; } = 200;
    }
}
