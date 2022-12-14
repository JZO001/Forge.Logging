using System;

namespace Forge.Logging.Abstraction
{

    /// <summary>This class is used by client applications to request logger instances.</summary>
    public class LogManager
    {

        private static ILoggerWrapper mLogger = NullLogger.Instance;

        /// <summary>Initializes a new instance of the <see cref="LogManager"/> class.</summary>
        protected LogManager() { }

        /// <summary>Gets or sets the logger wrapper.</summary>
        /// <value>The logger wrapper.</value>
        public static ILoggerWrapper LOGGER
        {
            get { return mLogger; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                mLogger = value;
            }
        }

        /// <summary>Gets the logger.</summary>
        /// <returns>ILog</returns>
        public static ILog GetLogger()
        {
            return LOGGER.GetLogger();
        }

        /// <summary>Gets the logger.</summary>
        /// <typeparam name="TLoggerType">The type of the logger type.</typeparam>
        /// <returns>ILog&lt;TLoggerType&gt;</returns>
        public static ILog<TLoggerType> GetLogger<TLoggerType>()
        {
            return LOGGER.GetLogger<TLoggerType>();
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="name">The category name.</param>
        /// <returns>ILog</returns>
        public static ILog GetLogger(string name)
        {
            return LOGGER.GetLogger(name);
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="type">The cateogry type.</param>
        /// <returns>ILog</returns>
        public static ILog GetLogger(Type type)
        {
            return LOGGER.GetLogger(type);
        }

    }

}
