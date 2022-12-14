using System;

namespace Forge.Logging.Abstraction
{

    /// <summary>The ILog interface is use by application to log messages into the underlying logger framework.</summary>
    public interface ILog
    {

        /// <summary>Gets a value indicating whether this instance is fatal enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.</value>
        bool IsFatalEnabled { get; }

        /// <summary>Gets a value indicating whether this instance is warn enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.</value>
        bool IsWarnEnabled { get; }

        /// <summary>Gets a value indicating whether this instance is information enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is information enabled; otherwise, <c>false</c>.</value>
        bool IsInfoEnabled { get; }

        /// <summary>Gets a value indicating whether this instance is debug enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.</value>
        bool IsDebugEnabled { get; }

        /// <summary>Gets a value indicating whether this instance is error enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.</value>
        bool IsErrorEnabled { get; }

        /// <summary>Gets a value indicating whether this instance is trace enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is trace enabled; otherwise, <c>false</c>.</value>
        bool IsTraceEnabled { get; }

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Debug(string message, Exception exception);

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Error(string message, Exception exception);

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        void Fatal(string message);

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Fatal(string message, Exception exception);

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Info(string message, Exception exception);

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        void Warn(string message);

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Warn(string message, Exception exception);

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        void Trace(string message);

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Trace(string message, Exception exception);

    }

    /// <summary>The ILog interface is use by application to log messages into the underlying logger framework.</summary>
    public interface ILog<TLoggerType> : ILog
    {
    }

}
