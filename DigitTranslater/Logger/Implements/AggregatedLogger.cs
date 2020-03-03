using DigitTranslater.Logger.Interfaces;
using System.Collections.Generic;

namespace DigitTranslater.Logger.Implements
{
    public class AggregatedLogger : ILogger
    {
        private readonly List<ILogger> _loggers;

        public AggregatedLogger(params ILogger[] loggers)
        {
            _loggers = new List<ILogger>(loggers);
        }

        public void LogInformation(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogInformation(message);
            }
        }
    }
}