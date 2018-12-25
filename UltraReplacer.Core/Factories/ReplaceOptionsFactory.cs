using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraReplacer.Core.Models;
using UltraReplacer.Core.Serialization;

namespace UltraReplacer.Core.Factories
{
    public class ReplaceOptionsFactory : BaseOptionsFactory<ReplaceOptions>
    {
        ReplaceOptionsFactory()
        {
        }

        static ReplaceOptionsFactory _instance;

        public static BaseOptionsFactory<ReplaceOptions> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ReplaceOptionsFactory();
            }
            return _instance;
        }

        public override ReplaceOptions GetOptions()
        {
            if (options == null)
            {
                string replaceOptionsPath = GetReplaceOptionsFilepath();
                serializer = new JsonSerializer<ReplaceOptions>(replaceOptionsPath);

                if (!File.Exists(replaceOptionsPath))
                {
                    options = new ReplaceOptions();
                    serializer.Serialize(options);
                }
            }

            return serializer.Deserialize();
        }

        private string GetReplaceOptionsFilepath()
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["ReplaceOptionsFilename"]);
        }
    }
}
