using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.Logging
{
    public interface ILogger
    {
        void Debug(object message);
        bool IsDebugEnabled { get; }

        void LogException(Exception e, string message);
    }
}
