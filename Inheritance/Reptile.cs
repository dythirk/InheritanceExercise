using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public bool LaysEggs { get; set; }
        public bool ArePupilsVertical { get; set; }
        public bool CanBeDomesticated { get; set; }
    }
}
