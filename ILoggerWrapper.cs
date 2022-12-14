using System;

namespace Forge.Logging
{

    /// <summary>Wrapper interface for logger implementation</summary>
    public interface ILoggerWrapper
    {

        /// <summary>Gets the logger.</summary>
        /// <returns>ILog</returns>
        ILog GetLogger();

        /// <summary>Gets the logger.</summary>
        /// <typeparam name="TLoggerType">The type of the logger type.</typeparam>
        /// <returns>ILog</returns>
        ILog<TLoggerType> GetLogger<TLoggerType>();

        /// <summary>Gets the logger.</summary>
        /// <param name="name">The category name.</param>
        /// <returns>ILog</returns>
        ILog GetLogger(string name);

        /// <summary>Gets the logger.</summary>
        /// <param name="type">The category type.</param>
        /// <returns>ILog</returns>
        ILog GetLogger(Type type);

    }

}
