using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializationTest
{
    class Zebra : IAnimal
    {
        public int Amount { get; set; }
        public string Name { get; set; }

        public bool HasStripes = true;
        public IFoot Foot { get; set; }

        [JsonIgnore]
        public string TypeDiscriminator => nameof(Zebra);
    }
}
