using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanimarpeNlogElmah.Logging
{
    /// <summary>
    /// BaseLogger class. Implements the ILogger interface.
    /// It has all the methods to write entries in Nlog
    /// </summary>
    public class BaseLogger : ILogger
    {
        private readonly NLog.Logger logger;

        public BaseLogger(string loggerkey)
        {
            if (loggerkey != null && loggerkey != string.Empty)
                logger = NLog.LogManager.GetLogger(loggerkey);
        }

        public virtual void Debug(string message)
        {
            logger.Debug(message);
        }

        public virtual void Debug(string message, Exception ex)
        {
            logger.Debug(ex, message, null);
        }
        public virtual void Debug(string message, Exception ex, object[] parametros)
        {
            logger.Debug(ex, message, parametros);
        }


        public virtual void Error(string message)
        {
            logger.Error(message);
        }

        public virtual void Error(string message, Exception exception)
        {
            logger.Error(exception, message, null);
        }

        public virtual void Error(string message, Exception exception, object[] parametros)
        {
            logger.Error(exception, message, parametros);
        }

        public virtual void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public virtual void Fatal(string message, Exception exception)
        {
            logger.Fatal(exception, message, null);
        }

        public virtual void Fatal(string message, Exception exception, object[] parametros)
        {
            logger.Fatal(exception, message, parametros);
        }

        public virtual void Info(string message)
        {
            logger.Info(message);
        }

        public virtual void Trace(string message)
        {
            logger.Trace(message);
        }

        public virtual void Warn(string message)
        {
            logger.Warn(message);
        }
    }
}
