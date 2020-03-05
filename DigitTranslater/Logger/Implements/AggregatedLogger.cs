using System.Collections.Generic;
using DigitTranslater.Logger.Interfaces;

namespace DigitTranslater.Logger.Implements
{
    public class AggregatedLogger : ILogger
    {
        private readonly IEnumerable<ILogger> loggers;

        public AggregatedLogger(params ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void LogInformation(string message)
        {
            foreach (var logger in loggers)
            {
                logger.LogInformation(message);
            }
        }
    }
}