using System.Collections.Generic;

namespace DigitTranslater.Localization
{
    public class UaLocalizationNumbers : LanguageNumbersDescriptor
    {
        public override void InitLanguage()
        {
            Name = "UA";

            Units = new Dictionary<int, string>
            {
                { 0, "нуль" },
                { 1, "один" },
                { 2, "два" },
                { 3, "три" },
                { 4, "чотири" },
                { 5, "п'ять" },
                { 6, "шість" },
                { 7, "сім" },
                { 8, "вісім" },
                { 9, "дев'ять" },
                { 10, "десять" },
                { 11, "одинадцять" },
                { 12, "дванадцять" },
                { 13, "тринадцять" },
                { 14, "чотирнадцять" },
                { 15, "п'ятнадцять" },
                { 16, "шістнадцять" },
                { 17, "сімадцять" },
                { 18, "вісімнадцять" },
                { 19, "дев'ятьнадцять" }
            };

            Dozens = new Dictionary<int, string>
            {
                { 2, "двадцять" },
                { 3, "тридцять" },
                { 4, "сорок" },
                { 5, "п'ятдесят" },
                { 6, "шістдесят" },
                { 7, "сімдесят" },
                { 8, "вісімдесят" },
                { 9, "дев'яносто" }
            };

            Hundreds = new Dictionary<int, string>
            {
                { 1, "сто" },
                { 2, "двісті" },
                { 3, "триста" },
                { 4, "чотириста" },
                { 5, "п'ятсот" },
                { 6, "шістьсот" },
                { 7, "сімсот" },
                { 8, "вісімсот" },
                { 9, "дев'ятсот" }
            };

            Thousands = new Dictionary<int, string>
            {
                { 0, "тисяч" },
                { 1, "одна тисяча" },
                { 2, "дві тисячі" },
                { 3, "три тисячі" },
                { 4, "чотири тисячі" },
                { 5, "п'ять тисяч" },
                { 6, "шість тисяч" },
                { 7, "сім тисяч" },
                { 8, "вісім тисяч" },
                { 9, "дев'ять тисяч" }
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
                { 1, $"{Hundreds.GetValueOrDefault(1)} тисяч"},
                { 2, $"{Hundreds.GetValueOrDefault(2)} тисяч"},
                { 3, $"{Hundreds.GetValueOrDefault(3)} тисяч"},
                { 4, $"{Hundreds.GetValueOrDefault(4)} тисяч"},
                { 5, $"{Hundreds.GetValueOrDefault(5)} тисяч"},
                { 6, $"{Hundreds.GetValueOrDefault(6)} тисяч"},
                { 7, $"{Hundreds.GetValueOrDefault(7)} тисяч"},
                { 8, $"{Hundreds.GetValueOrDefault(8)} тисяч"},
                { 9, $"{Hundreds.GetValueOrDefault(9)} тисяч"}
            };
        }
    }
}