using DigitTranslater;
using DigitTranslater.Localization;
using System;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterRuTests
    {
        #region Private Members

        private LanguageNumbersDescriptor _localization;

        #endregion

        public ConverterRuTests()
        {
            _localization = new RuLocalizationNumbers();
        }

        [Theory]
        [InlineData(0, "ноль")]
        [InlineData(1, "один")]
        [InlineData(11, "одиннадцать")]
        [InlineData(35, "тридцать пять")]
        [InlineData(100, "сто")]
        [InlineData(345, "триста сорок пять")]
        [InlineData(999, "девятьсот девяносто девять")]
        [InlineData(1000, "одна тысяча")]
        [InlineData(1245, "одна тысяча двести сорок пять")]
        [InlineData(7777, "семь тысяч семьсот семьдесят семь")]
        [InlineData(45256, "сорок пять тысяч двести пятьдесят шесть")]
        [InlineData(90000, "девяносто тысяч")]
        [InlineData(99999, "девяносто девять тысяч девятьсот девяносто девять")]
        [InlineData(100000, "сто тысяч")]
        [InlineData(900000, "девятьсот тысяч")]
        [InlineData(999999, "девятьсот девяносто девять тысяч девятьсот девяносто девять")]
        public void ConvertNumber(int number, string expectedValue)
        {
            // Arrange
            var descriptor = new NumberDescriptor(number);

            // Act
            var result = Converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ConvertWrongNumber()
        {
            // Arrange
            var expectedMessage = "Input string was not in a correct format.";

            // Assert
            var exception = Assert.Throws<FormatException>(() => { var descriptor = new NumberDescriptor(-1); });
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}