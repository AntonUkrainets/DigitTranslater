using DigitTranslater.Localization;
using System.Collections.Generic;

namespace DigitTranslater
{
    public class EnLoсalizationNumbers : LanguageNumbersDescriptor
    {
        public override void InitLanguage()
        {
            Name = "EN";

            Units = new Dictionary<int, string>
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fiveteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" }
            };

            Dozens = new Dictionary<int, string>
            {
                { 2, "twenty" },
                { 3, "thirty" },
                { 4, "forty" },
                { 5, "fifty" },
                { 6, "sixty" },
                { 7, "seventy" },
                { 8, "eighty" },
                { 9, "ninety" }
            };

            Hundreds = new Dictionary<int, string>
            {
                { 1, $"{Units.GetValueOrDefault(1)} hundred" },
                { 2, $"{Units.GetValueOrDefault(2)} hundred" },
                { 3, $"{Units.GetValueOrDefault(3)} hundred" },
                { 4, $"{Units.GetValueOrDefault(4)} hundred" },
                { 5, $"{Units.GetValueOrDefault(5)} hundred" },
                { 6, $"{Units.GetValueOrDefault(6)} hundred" },
                { 7, $"{Units.GetValueOrDefault(7)} hundred" },
                { 8, $"{Units.GetValueOrDefault(8)} hundred" },
                { 9, $"{Units.GetValueOrDefault(9)} hundred" }
            };

            Thousands = new Dictionary<int, string>
            {
                { 0, "thousand" },
                { 1, $"{Units.GetValueOrDefault(1)} thousand" },
                { 2, $"{Units.GetValueOrDefault(2)} thousand" },
                { 3, $"{Units.GetValueOrDefault(3)} thousand" },
                { 4, $"{Units.GetValueOrDefault(4)} thousand" },
                { 5, $"{Units.GetValueOrDefault(5)} thousand" },
                { 6, $"{Units.GetValueOrDefault(6)} thousand" },
                { 7, $"{Units.GetValueOrDefault(7)} thousand" },
                { 8, $"{Units.GetValueOrDefault(8)} thousand" },
                { 9, $"{Units.GetValueOrDefault(9)} thousand" }
            };

            DozensThousands = new Dictionary<int, string>
            {
                { 1, Units.GetValueOrDefault(10) },
                { 2, Dozens.GetValueOrDefault(2) },
                { 3, Dozens.GetValueOrDefault(3) },
                { 4, Dozens.GetValueOrDefault(4) },
                { 5, Dozens.GetValueOrDefault(5) },
                { 6, Dozens.GetValueOrDefault(6) },
                { 7, Dozens.GetValueOrDefault(7) },
                { 8, Dozens.GetValueOrDefault(8) },
                { 9, Dozens.GetValueOrDefault(9) }
            };

            HundredsThousands = new Dictionary<int, string>
            {
                { 1, Hundreds.GetValueOrDefault(1) },
                { 2, Hundreds.GetValueOrDefault(2) },
                { 3, Hundreds.GetValueOrDefault(3) },
                { 4, Hundreds.GetValueOrDefault(4) },
                { 5, Hundreds.GetValueOrDefault(5) },
                { 6, Hundreds.GetValueOrDefault(6) },
                { 7, Hundreds.GetValueOrDefault(7) },
                { 8, Hundreds.GetValueOrDefault(8) },
                { 9, Hundreds.GetValueOrDefault(9) }
            };
        }
    }
}