using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsCarnivore { get; set; }
        public string MakesSound { get; set; }

        public void SetName (string name)
        {
            Name = name;
        }
    }
}
