using DigitTranslater;
using DigitTranslater.Localization;
using System;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterUaTests
    {
        #region Private Members

        private LanguageNumbersDescriptor _localization;

        #endregion

        public ConverterUaTests()
        {
            _localization = new UaLocalizationNumbers();
        }

        [Theory]
        [InlineData(0, "нуль")]
        [InlineData(1, "один")]
        [InlineData(11, "одинадцять")]
        [InlineData(35, "тридцять п'ять")]
        [InlineData(100, "сто")]
        [InlineData(345, "триста сорок п'ять")]
        [InlineData(999, "дев'ятсот дев'яносто дев'ять")]
        [InlineData(1000, "одна тисяча")]
        [InlineData(1245, "одна тисяча двісті сорок п'ять")]
        [InlineData(7777, "сім тисяч сімсот сімдесят сім")]
        [InlineData(45256, "сорок п'ять тисяч двісті п'ятдесят шість")]
        [InlineData(90000, "дев'яносто тисяч")]
        [InlineData(99999, "дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(100000, "сто тисяч")]
        [InlineData(900000, "дев'ятсот тисяч")]
        [InlineData(999999, "дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(1000000, "один мільйон")]
        [InlineData(8545324, "вісім мільйонів п'ятсот сорок п'ять тисяч триста двадцять чотири")]
        [InlineData(10000000, "десять мільйонів")]
        [InlineData(77243921, "сімдесят сім мільйонів двісті сорок три тисячі дев'ятсот двадцять один")]
        [InlineData(99999999, "дев'яносто дев'ять мільйонів дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(100000000, "сто мільйонів")]
        [InlineData(123478934, "сто двадцять три мільйона чотириста сімдесят вісім тисяч дев'ятсот тридцять чотири")]
        [InlineData(999999999, "дев'ятсот дев'яносто дев'ять мільйонів дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
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