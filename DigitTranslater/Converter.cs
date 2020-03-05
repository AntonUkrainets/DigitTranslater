using System.Collections.Generic;
using DigitTranslater.Describer.Implements;
using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater
{
    public static class Converter
    {
        private static readonly List<INumberPartDescriber> describers;

        static Converter()
        {
            describers = new List<INumberPartDescriber>
            {
                new HundredMillionDescriber(),
                new DozenMillionsDescriber(),
                new MillionDescriber(),
                new HundredThousandDescriber(),
                new DozenThousandDescriber(),
                new ThousandDescriber(),
                new HundredDescriber(),
                new DozenConverter(),
                new UnitDescriber(),
            };
        }

        public static string ConvertToString(
            int number,
            ILanguageNumbersDescriptor numbersDictionary
        )
        {
            var result = string.Empty;

            foreach (var describer in describers)
            {
                var part = describer.Describe(number, numbersDictionary);

                result += part;

                if (part != string.Empty)
                    result += " ";
            }

            return result.Trim();
        }
    }
}