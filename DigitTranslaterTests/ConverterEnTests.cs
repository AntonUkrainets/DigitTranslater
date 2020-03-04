using DigitTranslater;
using DigitTranslater.Localization;
using System;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterEnTests
    {
        #region Private Members

        private LanguageNumbersDescriptor _localization;

        #endregion

        public ConverterEnTests()
        {
            _localization = new EnLoсalizationNumbers();
        }

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(11, "eleven")]
        [InlineData(35, "thirty five")]
        [InlineData(100, "one hundred")]
        [InlineData(345, "three hundred forty five")]
        [InlineData(999, "nine hundred ninety nine")]
        [InlineData(1000, "one thousand")]
        [InlineData(1245, "one thousand two hundred forty five")]
        [InlineData(7777, "seven thousand seven hundred seventy seven")]
        [InlineData(45256, "forty five thousand two hundred fifty six")]
        [InlineData(90000, "ninety thousand")]
        [InlineData(99999, "ninety nine thousand nine hundred ninety nine")]
        [InlineData(100000, "one hundred thousand")]
        [InlineData(900000, "nine hundred thousand")]
        [InlineData(999999, "nine hundred ninety nine thousand nine hundred ninety nine")]
        [InlineData(1000000, "one million")]
        [InlineData(8545324, "eight millions five hundred forty five thousand three hundred twenty four")]
        [InlineData(10000000, "ten millions")]
        [InlineData(77243921, "seventy seven millions two hundred forty three thousand nine hundred twenty one")]
        [InlineData(99999999, "ninety nine millions nine hundred ninety nine thousand nine hundred ninety nine")]
        [InlineData(100000000, "one hundred millions")]
        [InlineData(123478934, "one hundred twenty three millions four hundred seventy eight thousand nine hundred thirty four")]
        [InlineData(999999999, "nine hundred ninety nine millions nine hundred ninety nine thousand nine hundred ninety nine")]
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