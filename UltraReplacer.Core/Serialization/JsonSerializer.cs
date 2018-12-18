using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.Core.Serialization
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        string _path;

        /// <summary>
        /// Instantiates an Json serializer by providing a source path of Json files.
        /// </summary>
        /// <param name="path">Path where Json files are stored to be serialized.</param>
        public JsonSerializer(string path)
        {
            _path = path;
        }

        public T Deserialize()
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(_path));
        }

        public void Serialize(T value)
        {
            JsonConvert.SerializeObject(value);

            using (StreamWriter sw = new StreamWriter(_path))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;
                    serializer.Serialize(writer, value);
                }
            }
        }
    }
}
