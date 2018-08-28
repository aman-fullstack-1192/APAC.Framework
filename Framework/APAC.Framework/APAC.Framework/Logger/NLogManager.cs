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
        public const string LogError = "ERROR";

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

        public static long ScopeIn(string Scopename, string componentName, Guid traceToken, String projectName)
        {
            long startTicks = DateTime.UtcNow.Ticks;
            WriteNlogNetDetails(logman, String.Format("Scope - {0} Started", Scopename), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogDebug);
            return startTicks;
            
        }
        
        public static long ScopeOut(string Scopename, string componentName, Guid traceToken, String projectName, long startTicks)
        {
            TimeSpan elapsedSpan = new TimeSpan(DateTime.UtcNow.Ticks - startTicks);
            long endTime = (long) elapsedSpan.TotalMilliseconds;
            WriteNlogNetDetails(logman, String.Format("Scope - {0} ended in {1} ms", Scopename, endTime), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogDebug);
            return endTime;
        }

        public static void Debug(object message, string componentName, string projectName, Guid traceToken)
        {
            WriteNlogNetDetails(logman, message == null ? string.Empty : message.ToString(), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogDebug);
        }

        public static void Error(object message, string componentName, string serviceName, string projectName, Exception ex, Guid traceToken, string searchKey)
        {
            WriteNlogNetDetails(logman, message == null ? string.Empty : message.ToString(), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogError, 0, ex);
        }

        public static void Error(object message, string componentName, string projectName, Exception ex, Guid traceToken)
        {
            WriteNlogNetDetails(logman, message == null ? string.Empty : message.ToString(), componentName, ServiceNotSet, projectName, traceToken, SearchKeyNotSet, LogError, 0, ex);
        }

        private static void WriteNlogNetDetails(Logger logger, string logtowrite, string componentName, string serviceName, string projectName, Guid traceToken,string searchKey, string logLevel, int eventId = 0, Exception exToLog = null)
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

                    case LogError:
                        currentLogEvent = new LogEventInfo(LogLevel.Error, logger.Name, "");
                        currentLogEvent.Message = !string.IsNullOrWhiteSpace(logtowrite) ? logtowrite : (exToLog.InnerException).ToString();
                        currentLogEvent.Exception = exToLog;
                        currentLogEvent = CreateNLogEvent(currentLogEvent, logtowrite, componentName, serviceName, projectName, traceToken, searchKey, logLevel, eventId);
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

        private static LogEventInfo CreateNLogEvent(LogEventInfo currentLogEvent, string logtowrite, string componentName, string serviceName, string projectName, Guid traceToken, string searchKey, string logLevel, int eventId = 0)
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