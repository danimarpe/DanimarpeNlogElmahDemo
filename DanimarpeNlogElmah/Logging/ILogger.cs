using System;

namespace DanimarpeNlogElmah.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// Nivel Más detallado del sistema . Solamente Logs 
        /// </summary>
        /// <param name="message"></param>
        void Trace(string message);
        /// <summary>
        /// Información detallada del flujo del sistema - Solamente Logs
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);
        /// <summary>
        /// Información detallada del flujo del sistema - Solamente Logs
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message, Exception ex);
        /// <summary>
        /// Información detallada del flujo del sistema - Solamente Logs
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="parametros"></param>
        void Debug(string message, Exception ex, object[] parametros);
        /// <summary>
        ///  Captura de eventos del sistema (star/stop, etc.) - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);
        /// <summary>
        /// Captura de situaciones inesperadas (no tienen porque significar algó mal) - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);
        /// <summary>
        /// Captura de situaciones inesperadas en que ha ido mal algo - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
        /// <summary>
        /// Captura de situaciones inesperadas en que ha ido mal algo - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Error(string message, Exception exception);
        /// <summary>
        /// Captura de situaciones inesperadas en que ha ido mal algo - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Error(string message, Exception exception, object[] parametros);
        /// <summary>
        /// Captura de situaciones en los que algo ha ido mal y ha provocado que un flujo de aplicación (o la aplicación misma) se finalice - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message);
        /// <summary>
        /// Captura de situaciones en los que algo ha ido mal y ha provocado que un flujo de aplicación (o la aplicación misma) se finalice - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message, Exception exception);
        /// <summary>
        /// Captura de situaciones en los que algo ha ido mal y ha provocado que un flujo de aplicación (o la aplicación misma) se finalice - Visible en consolas de estado
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Fatal(string message, Exception exception, object[] parametros);
    }
}
