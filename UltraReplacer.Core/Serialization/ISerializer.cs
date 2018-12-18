using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.Core.Serialization
{
    public interface ISerializer<T>
    {
        void Serialize(T value);
        T Deserialize();
    }
}
