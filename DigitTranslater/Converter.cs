namespace DigitTranslater
{
    public static class Converter
    {
        public static string ConvertToString(NumberDescriptor descriptor, ILanguageNumbersDescriptor numbers)
        {
            var result = string.Empty;

            if(descriptor.HundredsThousands > 0)
            {
                result += $"{numbers.HundredsThousands[descriptor.HundredsThousands]} ";
            }

            if(descriptor.DozensThousands > 0)
            {
                result += $"{numbers.DozensThousands[descriptor.DozensThousands]} ";
            }

            if (descriptor.Thousands > 0 || descriptor.DozensThousands > 0 || descriptor.HundredsThousands > 0)
            {
                result += $"{numbers.Thousands[descriptor.Thousands]} ";
            }

            if (descriptor.Hundreds > 0)
            {
                result += $"{numbers.Hundreds[descriptor.Hundreds]} ";
            }

            if (descriptor.Dozens > 1)
            {
                result += $"{numbers.Dozens[descriptor.Dozens]} ";
            }

            if (descriptor.Dozens == 1)
            {
                var index = 10 + descriptor.Units;

                result += $"{numbers.Units[index]} ";
            }

            if (descriptor.Units > 0 && descriptor.Dozens != 1)
            {
                var index = descriptor.Units;

                result += $"{numbers.Units[index]} ";
            }

            if (descriptor.Units == 0 &&
                descriptor.Dozens == 0 &&
                descriptor.Hundreds == 0 &&
                descriptor.Thousands == 0 &&
                descriptor.DozensThousands == 0 &&
                descriptor.HundredsThousands == 0)
            {
                var index = descriptor.Units;

                result += $"{numbers.Units[index]} ";
            }

            return result.Trim();
        }
    }
}