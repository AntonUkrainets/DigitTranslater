namespace DigitTranslater
{
    public static class Converter
    {
        public static string ConvertToString(NumberDescriptor descriptor, ILanguageNumbersDescriptor numbers)
        {
            var result = string.Empty;

            if (descriptor.HundredsMillions > 0)
            {
                result += $"{numbers.HundredsMillions[descriptor.HundredsMillions]} ";
            }

            if (descriptor.DozensMillions > 0)
            {
                result += $"{numbers.DozensMillions[descriptor.DozensMillions]} ";
            }

            if (descriptor.Millions > 0 ||
                descriptor.DozensMillions > 0 ||
                descriptor.HundredsMillions > 0)
            {
                result += $"{numbers.Millions[descriptor.Millions]} ";
            }

            if (descriptor.HundredsThousands > 0)
            {
                result += $"{numbers.HundredsThousands[descriptor.HundredsThousands]} ";
            }

            if(descriptor.DozensThousands > 0)
            {
                result += $"{numbers.DozensThousands[descriptor.DozensThousands]} ";
            }

            if (descriptor.Thousands > 0 || 
                descriptor.DozensThousands > 0 || 
                descriptor.HundredsThousands > 0)
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

            if (descriptor.Units > 0 && 
                descriptor.Dozens != 1)
            {
                var index = descriptor.Units;

                result += $"{numbers.Units[index]} ";
            }

            if (descriptor.Units == 0 &&
                descriptor.Dozens == 0 &&
                descriptor.Hundreds == 0 &&
                descriptor.Thousands == 0 &&
                descriptor.DozensThousands == 0 &&
                descriptor.HundredsThousands == 0 &&
                descriptor.Millions == 0 &&
                descriptor.DozensMillions == 0 &&
                descriptor.HundredsMillions == 0)
            {
                var index = descriptor.Units;

                result += $"{numbers.Units[index]} ";
            }

            return result.Trim();
        }
    }
}