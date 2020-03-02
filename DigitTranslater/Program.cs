using DigitTranslater.Localization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitTranslater
{
    partial class Program
    {
        #region Private Members
        private static List<ILanguageNumbersDescriptor> _languageNumbersDescriptors;
        #endregion

        public static void Main(string[] args)
        {
            try
            {
                if (!ParametersValid(args))
                {
                    ShowHelp();
                    return;
                }

                _languageNumbersDescriptors = new List<ILanguageNumbersDescriptor>
                {
                    new EnLoсalizationNumbers(),
                    new RuLocalizationNumbers(),
                    new UaLocalizationNumbers(),
                };

                var converter = new Converter();

                var inputData = GetInputData(args);

                var localization = _languageNumbersDescriptors.First(x => x.Name == inputData.LocalizationName);

                var numberDescriptor = new NumberDescriptor(inputData.Number);
                var result = converter.ConvertToString(numberDescriptor, localization);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool ParametersValid(string[] args)
        {
            return args.Length == 2;
        }

        private static void ShowHelp()
        {
            Console.WriteLine("cd /?");
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
            {
                throw new ArgumentException($"Number '{numberArgument}' has incorrect format");
            }

            return new InputData
            {
                LocalizationName = localization.Name,
                Number = number
            };
        }
    }
}