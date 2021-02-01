using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore.Logging
{
    public interface ILogger
    {
        void LogInfo(string i_Message);

        void LogWarn(string i_Message);

        void LogError(string i_Message);
    }
}
