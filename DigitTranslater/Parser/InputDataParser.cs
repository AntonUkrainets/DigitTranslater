using System;
using System.Collections.Generic;
using System.Linq;
using DigitTranslater.Localization.Interfaces;
using DigitTranslater.Logger.Interfaces;
using DigitTranslater.Model;
using DigitTranslater.Validation;

namespace DigitTranslater.Parser
{
    public class InputDataParser
    {
        private readonly IEnumerable<ILanguageNumbersDescriptor> languageNumbersDescriptors;
        private readonly ILogger logger;

        public InputDataParser(
            IEnumerable<ILanguageNumbersDescriptor> languageNumbersDescriptors,
            ILogger logger
        )
        {
            this.languageNumbersDescriptors = languageNumbersDescriptors;
            this.logger = logger;
        }

        public InputData GetInputData(string[] args)
        {
            var localizationNameArgument = args[0];

            var localization = languageNumbersDescriptors
                .FirstOrDefault(l => string.Equals(l.Name, localizationNameArgument, StringComparison.InvariantCultureIgnoreCase));

            if (localization == null)
                throw new NotSupportedException($"Localization '{localizationNameArgument}' is not supported");

            var numberArgument = args[1];

            if (!int.TryParse(numberArgument, out int number))
                throw new ArgumentException($"Number '{numberArgument}' has incorrect format");

            if (Validator.IsNumberOverflow(number))
                throw new OverflowException($"The number '{number}' must be less than {number}");

            logger.LogInformation($"Input data: Localization='{localization.Name}'; Number='{number}';");

            return new InputData
            {
                LocalizationName = localization.Name,
                Number = number
            };
        }
    }
}