using System.Collections.Generic;

namespace DigitTranslater.Localization
{
    public abstract class LanguageNumbersDescriptor : ILanguageNumbersDescriptor
    {
        public string Name { get; protected set; }

        public IReadOnlyDictionary<int, string> Units { get; protected set; }

        public IReadOnlyDictionary<int, string> Dozens { get; protected set; }

        public IReadOnlyDictionary<int, string> Hundreds { get; protected set; }

        public IReadOnlyDictionary<int, string> Thousands { get; protected set; }

        public IReadOnlyDictionary<int, string> DozensThousands { get; protected set; }

        public IReadOnlyDictionary<int, string> HundredsThousands { get; protected set; }

        public IReadOnlyDictionary<int, string> Millions { get; protected set; }

        public IReadOnlyDictionary<int, string> DozensMillions { get; protected set; }

        public IReadOnlyDictionary<int, string> HundredsMillions { get; protected set; }

        public LanguageNumbersDescriptor()
        {
            InitLanguage();
        }

        public abstract void InitLanguage();
    }
}