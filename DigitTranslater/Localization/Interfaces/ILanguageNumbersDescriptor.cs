using System.Collections.Generic;

namespace DigitTranslater
{
    public interface ILanguageNumbersDescriptor
    {
        string Name { get; }

        IReadOnlyDictionary<int, string> Units { get; }

        IReadOnlyDictionary<int, string> Dozens { get; }

        IReadOnlyDictionary<int, string> Hundreds { get; }

        IReadOnlyDictionary<int, string> Thousands { get; }

        IReadOnlyDictionary<int, string> DozensThousands { get; }

        IReadOnlyDictionary<int, string> HundredsThousands { get; }

        IReadOnlyDictionary<int, string> Millions { get; }

        IReadOnlyDictionary<int, string> DozensMillions { get; }

        IReadOnlyDictionary<int, string> HundredsMillions { get; }
    }
}