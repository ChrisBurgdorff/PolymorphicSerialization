using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTest
{
    internal class Horse : IAnimal
    {
        public int Amount { get; set; }
        public string Name { get; set; }

        public bool HasStripes = true;
        public IFoot Foot { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
