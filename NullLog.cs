using System;

namespace Forge.Logging
{

    /// <summary>Empty log. Default implementation, do nothing.</summary>
    public class NullLog : ILog
    {

        /// <summary>Gets a value indicating whether this instance is fatal enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.</value>
        public bool IsFatalEnabled { get { return false; } }

        /// <summary>Gets a value indicating whether this instance is warn enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.</value>
        public bool IsWarnEnabled { get { return false; } }

        /// <summary>Gets a value indicating whether this instance is information enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is information enabled; otherwise, <c>false</c>.</value>
        public bool IsInfoEnabled { get { return false; } }

        /// <summary>Gets a value indicating whether this instance is debug enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.</value>
        public bool IsDebugEnabled { get { return false; } }

        /// <summary>Gets a value indicating whether this instance is error enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.</value>
        public bool IsErrorEnabled { get { return false; } }

        /// <summary>Gets a value indicating whether this instance is trace enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is trace enabled; otherwise, <c>false</c>.</value>
        public bool IsTraceEnabled { get { return false; } }

        /// <summary>Initializes a new instance of the <see cref="NullLog" /> class.</summary>
        internal NullLog()
        {
        }

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
        }

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(string message, Exception exception)
        {
        }

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
        }

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(string message, Exception exception)
        {
        }

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        public void Fatal(string message)
        {
        }

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(string message, Exception exception)
        {
        }

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
        }

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(string message, Exception exception)
        {
        }

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
        }

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(string message, Exception exception)
        {
        }

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        public void Trace(string message)
        {
        }

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Trace(string message, Exception exception)
        {
        }

    }

    /// <summary>Empty log. Default implementation, do nothing.</summary>
    /// <typeparam name="TLoggerType">The type of the logger type.</typeparam>
    public class NullLog<TLoggerType> : NullLog, ILog<TLoggerType>
    {

        /// <summary>Initializes a new instance of the <see cref="NullLog{TLoggerType}" /> class.</summary>
        internal NullLog()
        {
        }

    }

}
