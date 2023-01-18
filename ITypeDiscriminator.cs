using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTest
{
    public interface ITypeDiscriminator
    {
        string TypeDiscriminator { get; }
    }
}
