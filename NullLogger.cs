using System;

namespace Forge.Logging
{

    /// <summary>Empty logger. Default implementation, do nothing.</summary>
    /// <seealso cref="Forge.Logging.ILoggerWrapper" />
    public sealed class NullLogger : ILoggerWrapper
    {

        private static readonly NullLog NULL_LOG = new NullLog();

        private NullLogger() { }

        /// <summary>Gets the singleton instance.</summary>
        /// <value>The instance.</value>
        public static NullLogger Instance { get; private set; } = new NullLogger();

        /// <summary>Gets the logger.</summary>
        /// <returns>ILog</returns>
        public ILog GetLogger()
        {
            return NULL_LOG;
        }

        /// <summary>Gets the logger.</summary>
        /// <typeparam name="TLoggerType">The type of the logger type.</typeparam>
        /// <returns>ILog</returns>
        public ILog<TLoggerType> GetLogger<TLoggerType>()
        {
            return new NullLog<TLoggerType>();
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="name">The name.</param>
        /// <returns>ILog</returns>
        public ILog GetLogger(string name)
        {
            return NULL_LOG;
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="type">The category type.</param>
        /// <returns>ILog</returns>
        public ILog GetLogger(Type type)
        {
            return NULL_LOG;
        }

    }

}
