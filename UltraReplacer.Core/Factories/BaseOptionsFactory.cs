using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraReplacer.Core.Models;
using UltraReplacer.Core.Serialization;

namespace UltraReplacer.Core.Factories
{
    public abstract class BaseOptionsFactory<T> where T : class
    {
        internal ISerializer<T> serializer;
        internal T options;

        public abstract T GetOptions();
    }
}
