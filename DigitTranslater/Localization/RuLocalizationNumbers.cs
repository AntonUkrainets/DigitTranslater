using DigitTranslater.Localization;
using System.Collections.Generic;

namespace DigitTranslater
{
    public class RuLocalizationNumbers : LanguageNumbersDescriptor
    {
        public override void InitLanguage()
        {
            Name = "RU";

            Units = new Dictionary<int, string>
            {
                { 0, "ноль" },
                { 1, "один" },
                { 2, "два" },
                { 3, "три" },
                { 4, "четыре" },
                { 5, "пять" },
                { 6, "шесть" },
                { 7, "семь" },
                { 8, "восемь" },
                { 9, "девять" },
                { 10, "десять" },
                { 11, "одиннадцать" },
                { 12, "двенадцать" },
                { 13, "тринадцать" },
                { 14, "четырнадцать" },
                { 15, "пятнадцать" },
                { 16, "шестнадцать" },
                { 17, "семнадцать" },
                { 18, "восемнадцать" },
                { 19, "девятнадцать" }
            };

            Dozens = new Dictionary<int, string>
            {
                { 2, "двадцать" },
                { 3, "тридцать" },
                { 4, "сорок" },
                { 5, "пятьдесят" },
                { 6, "шестьдесят" },
                { 7, "семьдесят" },
                { 8, "восемьдесят" },
                { 9, "девяносто" }
            };

            Hundreds = new Dictionary<int, string>
            {
                { 1, "сто" },
                { 2, "двести" },
                { 3, "триста" },
                { 4, "четыреста" },
                { 5, "пятьсот" },
                { 6, "шестьсот" },
                { 7, "семьсот" },
                { 8, "восемьсот" },
                { 9, "девятьсот" }
            };

            Thousands = new Dictionary<int, string>
            {
                { 0, "тысяч" },
                { 1, "одна тысяча" },
                { 2, "две тысячи" },
                { 3, "три тысячи" },
                { 4, "четыре тысячи" },
                { 5, "пять тысяч" },
                { 6, "шесть тысяч" },
                { 7, "семь тысяч" },
                { 8, "восемь тысяч" },
                { 9, "девять тысяч" }
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
                { 1, $"{Hundreds.GetValueOrDefault(1)} тысяч"},
                { 2, $"{Hundreds.GetValueOrDefault(2)} тысяч"},
                { 3, $"{Hundreds.GetValueOrDefault(3)} тысяч"},
                { 4, $"{Hundreds.GetValueOrDefault(4)} тысяч"},
                { 5, $"{Hundreds.GetValueOrDefault(5)} тысяч"},
                { 6, $"{Hundreds.GetValueOrDefault(6)} тысяч"},
                { 7, $"{Hundreds.GetValueOrDefault(7)} тысяч"},
                { 8, $"{Hundreds.GetValueOrDefault(8)} тысяч"},
                { 9, $"{Hundreds.GetValueOrDefault(9)} тысяч"}
            };
        }
    }
}