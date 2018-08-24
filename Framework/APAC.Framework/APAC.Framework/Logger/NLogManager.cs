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
        #region Public Constants
        public const string LogDebug = "DEBUG";


        #endregion

        private static readonly Logger logman = LogManager.GetCurrentClassLogger();

        private const string ServiceNotSet = "Service Not Specified";
        private const string SearchKeyNotSet = "Search Key Not Specified";

        #region Old Code
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
        #endregion

        public static void ScopeIn(string Scopename, string message)
        {

        }

        public static void Debug(object message, string componentName, string projectName, Guid traceToken)
        {
            WriteNlogNetDetails(logman, message == null ? string.Empty : message.ToString(), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogDebug);
        }

        private static void WriteNlogNetDetails(Logger logger, string logtowrite, string componentName, string serviceName, string projectName, Guid traceToken,string searchKey, string logLevel, Exception exToLog = null)
        {
            try
            {
                LogEventInfo currentLogEvent = null;
                switch (logLevel)
                {
                    case LogDebug:
                        currentLogEvent = new LogEventInfo(LogLevel.Debug, logger.Name, "");
                        currentLogEvent.Message = logtowrite;
                        currentLogEvent = CreateNLogEvent(currentLogEvent, logtowrite, componentName, serviceName, projectName, traceToken, searchKey, logLevel);
                        logger.Log(currentLogEvent);
                        break;
                    default:
                        currentLogEvent = new LogEventInfo(LogLevel.Info, logger.Name, "");

                        if (exToLog == null)
                        {
                            currentLogEvent.Message = logtowrite;
                        }
                        else
                        {
                            currentLogEvent.Level = LogLevel.Error;
                            currentLogEvent.Message = !string.IsNullOrWhiteSpace(logtowrite) ? logtowrite : (exToLog.InnerException).ToString();
                            currentLogEvent.Exception = exToLog;
                        }
                        break;
                }
               

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private static LogEventInfo CreateNLogEvent(LogEventInfo currentLogEvent, string logtowrite, string componentName, string serviceName, string projectName, Guid traceToken, string searchKey, string logLevel)
        {
            currentLogEvent.Properties["loggedAt"] = DateTime.UtcNow.ToString("yyyy.MM.dd HH:mm:ss:fff");
            currentLogEvent.Properties["serverName"] = Environment.MachineName;
            currentLogEvent.Properties["componentName"] = componentName;
            currentLogEvent.Properties["serviceName"] = serviceName;
            currentLogEvent.Properties["projectName"] = projectName;
            currentLogEvent.Properties["traceToken"] = traceToken;
            currentLogEvent.Properties["searchKey"] = searchKey;
            currentLogEvent.Properties["logLevel"] = logLevel;
            return currentLogEvent;
        }

    }

    [Serializable()]
    public enum LogType
    {
        Error, Info, Warning, Trace
    }
}