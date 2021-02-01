using FBAppCore.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore
{
    public class Logger : ILogger
    {
        private const string _kErrorSeverity = "Error";
        private const string _kInfoSeverity = "Info";
        private const string _kWarnSeverity = "Warning";
        private string m_LogFilePath;
        
        private Logger(string i_LogFilePath = null)
        {
            m_LogFilePath = i_LogFilePath ?? string.Empty;
        }

        public static ILogger Create(string i_LogFilePath = null)
            => new Logger(i_LogFilePath);

        public void LogError(string i_Message)
            => Log(_kErrorSeverity, i_Message);

        public void LogInfo(string i_Message)
            => Log(_kInfoSeverity, i_Message);

        public void LogWarn(string i_Message)
            => Log(_kWarnSeverity, i_Message);

        private void Log(string i_Severity, string i_LogMessage)
        {
            using (StreamWriter writer = File.AppendText(m_LogFilePath))
            {
                writer.Write($"\r\n{i_Severity} : ");
                writer.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                writer.WriteLine("  :");
                writer.WriteLine($"  :{i_LogMessage}");
                writer.WriteLine("-------------------------------");
            }
        }
    }
}
