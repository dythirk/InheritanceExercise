using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanHover { get; set; }
        public bool IsBirdOfPrey { get; set; }
        public bool IsAquatic { get; set; }
        public bool IsScavenger { get; set; }

    }
}
