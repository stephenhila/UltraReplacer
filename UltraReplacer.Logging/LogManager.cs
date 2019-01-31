using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.Logging
{
    public static class LogManager
    {
        static ILogger _instance;

        public static ILogger GetLogger(Type type)
        {
            if (_instance == null)
            {
                _instance = new Log4NetWrapper(type);
            }

            return _instance;
        }
    }
}
