using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializationTest
{
    internal class Hoof : IFoot
    {
        public int NumberOfToes { get; set; }

        [JsonIgnore]
        public string TypeDiscriminator => nameof(Hoof);
    }
}
