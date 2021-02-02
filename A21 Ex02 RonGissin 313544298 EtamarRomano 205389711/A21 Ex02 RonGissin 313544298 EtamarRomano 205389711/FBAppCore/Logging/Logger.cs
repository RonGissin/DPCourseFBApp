using System;
using System.IO;
using FBAppCore.Logging;

namespace FBAppCore
{
    public class Logger : ILogger
    {
        private const string k_ErrorSeverity = "Error";
        private const string k_InfoSeverity = "Info";
        private const string k_WarnSeverity = "Warning";
        private const string k_DefaultLogFilePath = "LikeHandlerLog.txt";
        private readonly string r_LogFilePath;
        
        private Logger(string i_LogFilePath = null)
        {
            r_LogFilePath = i_LogFilePath ?? k_DefaultLogFilePath;
        }

        public static ILogger Create(string i_LogFilePath = null)
            => new Logger(i_LogFilePath);

        public void LogError(string i_Message)
            => Log(k_ErrorSeverity, i_Message);

        public void LogInfo(string i_Message)
            => Log(k_InfoSeverity, i_Message);

        public void LogWarn(string i_Message)
            => Log(k_WarnSeverity, i_Message);

        private void Log(string i_Severity, string i_LogMessage)
        {
            using (StreamWriter writer = File.AppendText(r_LogFilePath))
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
