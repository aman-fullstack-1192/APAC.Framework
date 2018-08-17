using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace APAC.Framework.HelperLibrary
{
    [Serializable()]
    public static class NLogManager
    {
        private static readonly Logger logman = LogManager.GetCurrentClassLogger();
        public static void Log(LogType level, string message, Exception exception)

        {
            switch (level)
            {
                case LogType.Error:
                    logman.Log(LogLevel.Error, exception , message , null);
                    break;
                case LogType.Info:
                    logman.Log(LogLevel.Info, exception, message, null);
                    break;
                case LogType.Warning:
                    logman.Log(LogLevel.Warn, exception, message, null);
                    break;
                case LogType.Trace:
                    logman.Log(LogLevel.Trace, exception, message, null);
                    break;
            }
            if (exception.InnerException != null)
  
            {
                Log(level, message, exception.InnerException);
            }
        }
        public static void Log(LogType level, string message)
        {
            switch (level)
            {
                case LogType.Error:
                    logman.Log(LogLevel.Error, message);
                    break;
                case LogType.Info:
                    logman.Log(LogLevel.Info, message);
                    break;
                case LogType.Warning:
                    logman.Log(LogLevel.Warn, message);
                    break;
                case LogType.Trace:
                    logman.Log(LogLevel.Trace, message);
                    break;
            }
        }

        public static void ScopeIn(string Scopename, string message)
        {

        }
    }

    [Serializable()]
    public enum LogType
    {
        Error, Info, Warning, Trace
    }
}