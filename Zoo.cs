using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTest
{
    class Zoo
    {
        public int NumberOfAnimals { get; set; }
        public string NameOfZoo { get; set; }

        public IAnimal Animal { get; set; }
    }
}
