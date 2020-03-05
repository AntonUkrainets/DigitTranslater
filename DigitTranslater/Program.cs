using System;
using System.Collections.Generic;
using System.Linq;
using DigitTranslater.Localization.Implements;
using DigitTranslater.Localization.Interfaces;
using DigitTranslater.Logger.Implements;
using DigitTranslater.Parser;
using DigitTranslater.Validation;

namespace DigitTranslater
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var logPath = "application.log";

            var logger = new AggregatedLogger(
                new FileLogger(logPath),
                new ConsoleLogger()
            );

            try
            {
                if (!Validator.IsParametersValid(args))
                {
                    logger.LogInformation("Input data must be in format <LocalizationType> <number>");

                    return;
                }

                var languageNumbersDescriptors = new List<ILanguageNumbersDescriptor>
                {
                    new EnLoсalizationNumbers(),
                    new RuLocalizationNumbers(),
                    new UaLocalizationNumbers()
                };

                var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger);
                var inputData = inputDataParser.GetInputData(args);

                var localization = languageNumbersDescriptors.First(l => l.Name == inputData.LocalizationName);

                var result = Converter.ConvertToString(inputData.Number, localization);

                logger.LogInformation($"Result: {result}");
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);
            }
        }
    }
}