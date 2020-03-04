using System;
using System.Collections.Generic;

namespace DigitTranslater
{
    public class NumberDescriptor
    {
        public int Units { get; set; }
        public int Dozens { get; set; }
        public int Hundreds { get; set; }
        public int Thousands { get; set; }
        public int DozensThousands { get; set; }
        public int HundredsThousands { get; set; }
        public int Millions { get; set; }
        public int DozensMillions { get; set; }
        public int HundredsMillions { get; set; }

        public NumberDescriptor(int number)
        {
            Init(number);
        }

        private void Init(int number)
        {
            var numberParts = ConvertToList(number);

            for (var index = 0; index < numberParts.Count; index++)
            {
                switch (index)
                {
                    case 0:
                        Units = numberParts[index];
                        break;
                    case 1:
                        Dozens = numberParts[index];
                        break;
                    case 2:
                        Hundreds = numberParts[index];
                        break;
                    case 3:
                        Thousands = numberParts[index];
                        break;
                    case 4:
                        DozensThousands = numberParts[index];
                        break;
                    case 5:
                        HundredsThousands = numberParts[index];
                        break;
                    case 6:
                        Millions = numberParts[index];
                        break;
                    case 7:
                        DozensMillions = numberParts[index];
                        break;
                    case 8:
                        HundredsMillions = numberParts[index];
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        private IList<int> ConvertToList(int number)
        {
            var ch = number.ToString().ToCharArray();

            var digits = new List<int>();

            foreach (var item in ch)
                digits.Insert(0, int.Parse($"{item}"));

            return digits;
        }
    }
}