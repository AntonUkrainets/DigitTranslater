using DigitTranslater.Localization;
using DigitTranslater.Logger.Implements;
using DigitTranslater.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitTranslater
{
    public partial class Program
    {
        private const string LogPath = "application.log";

        #region Private Members

        private static List<ILanguageNumbersDescriptor> _languageNumbersDescriptors;
        private static ILogger _logger;

        #endregion

        public static void Main(string[] args)
        {
            try
            {
                _logger = new AggregatedLogger(
                    new FileLogger(LogPath),
                    new ConsoleLogger()
                );

                if (!ParametersValid(args))
                {
                    ShowHelp();
                    return;
                }

                _languageNumbersDescriptors = new List<ILanguageNumbersDescriptor>
                {
                    new EnLoсalizationNumbers(),
                    new RuLocalizationNumbers(),
                    new UaLocalizationNumbers()
                };

                var inputData = GetInputData(args);

                var localization = _languageNumbersDescriptors.First(l => l.Name == inputData.LocalizationName);

                var numberDescriptor = new NumberDescriptor(inputData.Number);
                var result = Converter.ConvertToString(numberDescriptor, localization);

                _logger.LogInformation($"Result: {result}");
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
            }
        }

        private static bool ParametersValid(string[] args)
        {
            return args.Length == 2;
        }

        private static bool IsNumberOverflow(int number)
        {
            return number >= 1000000000;
        }

        private static void ShowHelp()
        {
            _logger.LogInformation("Input data must be in format <LocalizationType> <number>");
        }

        private static InputData GetInputData(string[] args)
        {
            var localizationNameArgument = args[0];

            var localization = _languageNumbersDescriptors
                .FirstOrDefault(l => string.Equals(l.Name, localizationNameArgument, StringComparison.InvariantCultureIgnoreCase));

            if (localization == null)
                throw new NotSupportedException($"Localization '{localizationNameArgument}' is not supported");

            var numberArgument = args[1];

            if (!int.TryParse(numberArgument, out int number))
                throw new ArgumentException($"Number '{numberArgument}' has incorrect format");

            if (IsNumberOverflow(number))
                throw new OverflowException($"The number '{number}' must be less than 1000,000,000");

            _logger.LogInformation($"Input data: Localization='{localization.Name}'; Number='{number}';");

            return new InputData
            {
                LocalizationName = localization.Name,
                Number = number
            };
        }
    }
}